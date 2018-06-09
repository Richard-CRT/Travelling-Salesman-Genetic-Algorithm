using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravellingSalesmanGeneticAlgorithm
{
    public partial class FormTravellingSalesman : Form
    {
        List<Individual> SortedPopulation;
        int Generation;

        public FormTravellingSalesman()
        {
            InitializeComponent();
            CanvasGraph_SizeChanged(null, null);
        }

        private void CanvasGraph_SizeChanged(object sender, EventArgs e)
        {
            LabelCanvasWidth.Text = CanvasGraph.Width.ToString() + " m";
            LabelCanvasHeight.Text = CanvasGraph.Height.ToString() + " m";
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            TravellingSalesmanProblem.SetParameters((int)this.NumericNodeCount.Value, this.CanvasGraph.Width, this.CanvasGraph.Height, (int)this.NumericPopulationSize.Value, (int)this.NumericNodeSeed.Value);
            Tuple<int, List<Node>> data = TravellingSalesmanProblem.GenerateNodes();
            List<Node> nodes = data.Item2;
            int seed = data.Item1;
            TextBoxActiveNodeSeed.Text = seed.ToString();
            CanvasGraph.ClearNodes();
            CanvasGraph.ClearPaths();
            CanvasGraph.AddNodes(nodes);
            CanvasGraph.RePaint();

            SortedPopulation = TravellingSalesmanProblem.GeneratePopulation();
            Generation = 0;

            Render();

            /*
            for (int i = TravellingSalesmanProblem.PopulationSize - 1; i >= 0; i--)
            {
                CanvasGraph.ClearPaths();
                CanvasGraph.AddPath(sortedPopulation[i]);
                CanvasGraph.RePaint();
                TextBoxDistance.Text = sortedPopulation[i].Distance.ToString("0.00");
                TextBoxDistance.Refresh();
            }
            */
        }

        private void Mutate()
        {
            SortedPopulation = TravellingSalesmanProblem.MutatePopulation();
            if (SortedPopulation != null)
            {
                Generation++;
            }
        }

        private void Render()
        {
            if (SortedPopulation != null)
            {
                CanvasGraph.ClearPaths();
                CanvasGraph.AddPath(SortedPopulation[0]);
                CanvasGraph.RePaint();
                TextBoxDistance.Text = SortedPopulation[0].Distance.ToString("0.00");
                TextBoxDistance.Refresh();
                TextBoxGeneration.Text = Generation.ToString();
                TextBoxDistance.Refresh();
            }
        }

        private void ButtonMutate_Click(object sender, EventArgs e)
        {
            Mutate();
            Render();
        }

        private void ButtonMutate10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Mutate();
            }
            Render();
        }

        private void ButtonMutate100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Mutate();
            }
            Render();
        }

        private void ButtonMutate1000_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Mutate();
            }
            Render();
        }
    }
}
