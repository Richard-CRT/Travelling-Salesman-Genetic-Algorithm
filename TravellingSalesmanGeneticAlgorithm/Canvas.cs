using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravellingSalesmanGeneticAlgorithm
{
    public partial class Canvas : UserControl
    {
        private List<Node> nodes;
        private List<Individual> paths;

        public Canvas()
        {
            InitializeComponent();
            ClearNodes();
            ClearPaths();
        }

        public void ClearNodes()
        {
            nodes = new List<Node>();
        }

        public void AddNodes(List<Node> newNodes)
        {
            nodes.AddRange(newNodes);
        }

        public void ClearPaths()
        {
            paths = new List<Individual>();
        }

        public void AddPath(Individual newPath)
        {
            paths.Add(newPath);
        }

        public void RePaint()
        {
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            base.OnPaint(e);

            using (Pen blackPen2 = new Pen(Color.Black, 2))
            {
                foreach (Individual individual in paths)
                {
                    for (int i = 0; i < TravellingSalesmanProblem.NodeCount - 1; i++)
                    {
                        e.Graphics.DrawLine(Pens.Black, individual.VisitOrder[i].X, individual.VisitOrder[i].Y, individual.VisitOrder[i + 1].X, individual.VisitOrder[i + 1].Y);
                    }
                }

                foreach (Node node in nodes)
                {
                    e.Graphics.DrawRectangle(blackPen2, node.X - 2, node.Y - 2, 5, 5);
                }
            }
        }
    }
}
