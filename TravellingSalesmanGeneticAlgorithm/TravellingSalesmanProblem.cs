using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesmanGeneticAlgorithm
{
    public static class TravellingSalesmanProblem
    {

        private static int activeNodeCount = 200;
        public static int NodeCount
        {
            get
            {
                return activeNodeCount;
            }
        }
        private static int activeMaxNodeX = 750;
        private static int activeMaxNodeY = 450;
        private static List<Node> nodes;
        private static Random nodeRandomGenerator;
        private static Random pathRandomGenerator = new Random();
        private static int activeNodeSeed;

        private static bool nodesGenerated = false;
        private static bool populationGenerated = false;

        private static int activePopulationSize = 1000;
        public static int PopulationSize
        {
            get
            {
                return activePopulationSize;
            }
        }
        private static List<Individual> population;

        public static void SetParameters(int newNodeCount, int newMaxNodeX, int newMaxNodeY, int newPopulationSize, int newNodeSeed = 0)
        {
            activeNodeCount = newNodeCount;
            activeMaxNodeX = newMaxNodeX;
            activeMaxNodeY = newMaxNodeY;
            activePopulationSize = newPopulationSize;
            activeNodeSeed = newNodeSeed;
        }

        public static Tuple<int, List<Node>> GenerateNodes()
        {
            nodesGenerated = true;
            int seed;
            if (activeNodeSeed == 0)
            {
                seed = System.DateTime.UtcNow.Millisecond;
            }
            else
            {
                seed = activeNodeSeed;
            }
            nodeRandomGenerator = new Random(seed);
            nodes = new List<Node>();
            for (int i = 0; i < activeNodeCount; i++)
            {
                int x = nodeRandomGenerator.Next(activeMaxNodeX);
                int y = nodeRandomGenerator.Next(activeMaxNodeY);
                nodes.Add(new Node(x, y));
            }
            return new Tuple<int, List<Node>>(seed, nodes);
        }

        public static List<Individual> GeneratePopulation()
        {
            if (nodesGenerated)
            {
                populationGenerated = true;
                population = new List<Individual>();
                for (int i = 0; i < activePopulationSize; i++)
                {
                    List<Node> newVisitOrder = nodes.Shuffle();
                    Individual newIndividual = new Individual(newVisitOrder);
                    population.Add(newIndividual);
                }
                population = SortPopulation();
                return population;
            }
            else
            {
                return null;
            }
        }

        private static Individual mutateIndividual(Individual individual)
        {
            int node1 = 0;
            int node2 = 0;

            while (node1 == node2)
            {
                node1 = pathRandomGenerator.Next(activeNodeCount);
                node2 = pathRandomGenerator.Next(activeNodeCount);
            }

            if (node1 > node2)
            {
                int temp = node1;
                node1 = node2;
                node2 = temp;
            }

            int length = node2 - node1;
            int half = (int)Math.Ceiling((double)length / 2);
            for (int i = 0; i < half; i++)
            {
                Node temp = individual.VisitOrder[node1 + i];
                individual.VisitOrder[node1 + i] = individual.VisitOrder[node2 - i];
                individual.VisitOrder[node2 - i] = temp;
            }
            individual.CalculateTotalDistance();
            return individual;
        }

        public static List<Individual> MutatePopulation()
        {
            if (populationGenerated)
            {
                int startPoint = (int)Math.Ceiling((double)activePopulationSize / 100);
                // Keep the best 1%
                // Produce the next 99% from mutating the best 99%
                for (int i = startPoint; i < activePopulationSize; i++)
                {
                    population[i] = new Individual(population[i - startPoint]);
                }

                for (int i = 0; i < activePopulationSize; i++)
                {
                    Individual individual = population[i];
                    individual = mutateIndividual(individual);
                }
                population = SortPopulation();
                return population;
            }
            else
            {
                return null;
            }
        }

        private static List<Individual> SortPopulation()
        {
            return population.OrderBy(individual => individual.Distance).ToList();
        }

        public static List<T> Shuffle<T>(this IList<T> list)
        {
            List<T> newList = list.ToList();
            int n = newList.Count;
            while (n > 1)
            {
                n--;
                int k = pathRandomGenerator.Next(n + 1);
                T value = newList[k];
                newList[k] = newList[n];
                newList[n] = value;
            }
            return newList;
        }
    }

    public class Individual
    {
        private double distance;
        public double Distance
        {
            get
            {
                return distance;
            }
        }

        public List<Node> VisitOrder;

        private double calculateDistance(Node node1, Node node2)
        {
            int differenceX = node2.X - node1.X;
            int differenceY = node2.Y - node1.Y;
            int powX = differenceX * differenceX;
            int powY = differenceY * differenceY;
            return Math.Sqrt(powX + powY);
        }

        public void CalculateTotalDistance()
        {
            double totalDistance = 0;
            for (int i = 0; i < TravellingSalesmanProblem.NodeCount - 1; i++)
            {
                totalDistance += calculateDistance(VisitOrder[i], VisitOrder[i + 1]);
            }
            distance = totalDistance;
        }

        public Individual(List<Node> newVisitOrder)
        {
            VisitOrder = newVisitOrder;
            CalculateTotalDistance();
        }

        public Individual(Individual clone)
        {
            distance = clone.Distance;
            VisitOrder = clone.VisitOrder.ToList();
        }
    }

    public class Node
    {
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }

        public Node(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
