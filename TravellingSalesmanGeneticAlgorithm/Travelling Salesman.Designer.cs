namespace TravellingSalesmanGeneticAlgorithm
{
    partial class FormTravellingSalesman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.LabelDistance = new System.Windows.Forms.Label();
            this.TextBoxDistance = new System.Windows.Forms.TextBox();
            this.LabelCanvasWidth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelCanvasHeight = new System.Windows.Forms.Label();
            this.LabelDistanceUnit = new System.Windows.Forms.Label();
            this.ButtonMutate = new System.Windows.Forms.Button();
            this.ButtonMutate10 = new System.Windows.Forms.Button();
            this.TextBoxGeneration = new System.Windows.Forms.TextBox();
            this.LabelGeneration = new System.Windows.Forms.Label();
            this.ButtonMutate100 = new System.Windows.Forms.Button();
            this.ButtonMutate1000 = new System.Windows.Forms.Button();
            this.NumericNodeCount = new System.Windows.Forms.NumericUpDown();
            this.LabelNodeCount = new System.Windows.Forms.Label();
            this.CanvasGraph = new TravellingSalesmanGeneticAlgorithm.Canvas();
            this.LabelPopulationSize = new System.Windows.Forms.Label();
            this.NumericPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.LabelNodeSeed = new System.Windows.Forms.Label();
            this.NumericNodeSeed = new System.Windows.Forms.NumericUpDown();
            this.TextBoxActiveNodeSeed = new System.Windows.Forms.TextBox();
            this.LabelActiveNodeSeed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNodeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNodeSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(12, 46);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerate.TabIndex = 1;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // LabelDistance
            // 
            this.LabelDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelDistance.AutoSize = true;
            this.LabelDistance.Location = new System.Drawing.Point(151, 658);
            this.LabelDistance.Name = "LabelDistance";
            this.LabelDistance.Size = new System.Drawing.Size(52, 13);
            this.LabelDistance.TabIndex = 2;
            this.LabelDistance.Text = "Distance:";
            // 
            // TextBoxDistance
            // 
            this.TextBoxDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxDistance.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxDistance.Location = new System.Drawing.Point(202, 655);
            this.TextBoxDistance.Name = "TextBoxDistance";
            this.TextBoxDistance.ReadOnly = true;
            this.TextBoxDistance.Size = new System.Drawing.Size(63, 20);
            this.TextBoxDistance.TabIndex = 3;
            this.TextBoxDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelCanvasWidth
            // 
            this.LabelCanvasWidth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelCanvasWidth.Location = new System.Drawing.Point(599, 3);
            this.LabelCanvasWidth.Name = "LabelCanvasWidth";
            this.LabelCanvasWidth.Size = new System.Drawing.Size(62, 21);
            this.LabelCanvasWidth.TabIndex = 4;
            this.LabelCanvasWidth.Text = "0 m";
            this.LabelCanvasWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LabelCanvasHeight);
            this.panel1.Controls.Add(this.CanvasGraph);
            this.panel1.Controls.Add(this.LabelCanvasWidth);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 572);
            this.panel1.TabIndex = 5;
            // 
            // LabelCanvasHeight
            // 
            this.LabelCanvasHeight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelCanvasHeight.Location = new System.Drawing.Point(1199, 269);
            this.LabelCanvasHeight.Name = "LabelCanvasHeight";
            this.LabelCanvasHeight.Size = new System.Drawing.Size(61, 21);
            this.LabelCanvasHeight.TabIndex = 5;
            this.LabelCanvasHeight.Text = "0 m";
            this.LabelCanvasHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDistanceUnit
            // 
            this.LabelDistanceUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelDistanceUnit.Location = new System.Drawing.Point(266, 658);
            this.LabelDistanceUnit.Name = "LabelDistanceUnit";
            this.LabelDistanceUnit.Size = new System.Drawing.Size(14, 13);
            this.LabelDistanceUnit.TabIndex = 6;
            this.LabelDistanceUnit.Text = "m";
            // 
            // ButtonMutate
            // 
            this.ButtonMutate.Location = new System.Drawing.Point(93, 46);
            this.ButtonMutate.Name = "ButtonMutate";
            this.ButtonMutate.Size = new System.Drawing.Size(75, 23);
            this.ButtonMutate.TabIndex = 7;
            this.ButtonMutate.Text = "Mutate";
            this.ButtonMutate.UseVisualStyleBackColor = true;
            this.ButtonMutate.Click += new System.EventHandler(this.ButtonMutate_Click);
            // 
            // ButtonMutate10
            // 
            this.ButtonMutate10.Location = new System.Drawing.Point(174, 46);
            this.ButtonMutate10.Name = "ButtonMutate10";
            this.ButtonMutate10.Size = new System.Drawing.Size(75, 23);
            this.ButtonMutate10.TabIndex = 8;
            this.ButtonMutate10.Text = "Mutate 10";
            this.ButtonMutate10.UseVisualStyleBackColor = true;
            this.ButtonMutate10.Click += new System.EventHandler(this.ButtonMutate10_Click);
            // 
            // TextBoxGeneration
            // 
            this.TextBoxGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxGeneration.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxGeneration.Location = new System.Drawing.Point(355, 655);
            this.TextBoxGeneration.Name = "TextBoxGeneration";
            this.TextBoxGeneration.ReadOnly = true;
            this.TextBoxGeneration.Size = new System.Drawing.Size(36, 20);
            this.TextBoxGeneration.TabIndex = 10;
            this.TextBoxGeneration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelGeneration
            // 
            this.LabelGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelGeneration.AutoSize = true;
            this.LabelGeneration.Location = new System.Drawing.Point(293, 658);
            this.LabelGeneration.Name = "LabelGeneration";
            this.LabelGeneration.Size = new System.Drawing.Size(62, 13);
            this.LabelGeneration.TabIndex = 9;
            this.LabelGeneration.Text = "Generation:";
            // 
            // ButtonMutate100
            // 
            this.ButtonMutate100.Location = new System.Drawing.Point(255, 46);
            this.ButtonMutate100.Name = "ButtonMutate100";
            this.ButtonMutate100.Size = new System.Drawing.Size(75, 23);
            this.ButtonMutate100.TabIndex = 11;
            this.ButtonMutate100.Text = "Mutate 100";
            this.ButtonMutate100.UseVisualStyleBackColor = true;
            this.ButtonMutate100.Click += new System.EventHandler(this.ButtonMutate100_Click);
            // 
            // ButtonMutate1000
            // 
            this.ButtonMutate1000.Location = new System.Drawing.Point(336, 46);
            this.ButtonMutate1000.Name = "ButtonMutate1000";
            this.ButtonMutate1000.Size = new System.Drawing.Size(75, 23);
            this.ButtonMutate1000.TabIndex = 12;
            this.ButtonMutate1000.Text = "Mutate 1000";
            this.ButtonMutate1000.UseVisualStyleBackColor = true;
            this.ButtonMutate1000.Click += new System.EventHandler(this.ButtonMutate1000_Click);
            // 
            // NumericNodeCount
            // 
            this.NumericNodeCount.Location = new System.Drawing.Point(81, 16);
            this.NumericNodeCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericNodeCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericNodeCount.Name = "NumericNodeCount";
            this.NumericNodeCount.Size = new System.Drawing.Size(64, 20);
            this.NumericNodeCount.TabIndex = 13;
            this.NumericNodeCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // LabelNodeCount
            // 
            this.LabelNodeCount.AutoSize = true;
            this.LabelNodeCount.Location = new System.Drawing.Point(13, 19);
            this.LabelNodeCount.Name = "LabelNodeCount";
            this.LabelNodeCount.Size = new System.Drawing.Size(67, 13);
            this.LabelNodeCount.TabIndex = 14;
            this.LabelNodeCount.Text = "Node Count:";
            // 
            // CanvasGraph
            // 
            this.CanvasGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasGraph.BackColor = System.Drawing.SystemColors.Window;
            this.CanvasGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasGraph.Location = new System.Drawing.Point(13, 26);
            this.CanvasGraph.Name = "CanvasGraph";
            this.CanvasGraph.Size = new System.Drawing.Size(1184, 546);
            this.CanvasGraph.TabIndex = 0;
            this.CanvasGraph.SizeChanged += new System.EventHandler(this.CanvasGraph_SizeChanged);
            // 
            // LabelPopulationSize
            // 
            this.LabelPopulationSize.AutoSize = true;
            this.LabelPopulationSize.Location = new System.Drawing.Point(152, 19);
            this.LabelPopulationSize.Name = "LabelPopulationSize";
            this.LabelPopulationSize.Size = new System.Drawing.Size(83, 13);
            this.LabelPopulationSize.TabIndex = 16;
            this.LabelPopulationSize.Text = "Population Size:";
            // 
            // NumericPopulationSize
            // 
            this.NumericPopulationSize.Location = new System.Drawing.Point(238, 16);
            this.NumericPopulationSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericPopulationSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericPopulationSize.Name = "NumericPopulationSize";
            this.NumericPopulationSize.Size = new System.Drawing.Size(78, 20);
            this.NumericPopulationSize.TabIndex = 15;
            this.NumericPopulationSize.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // LabelNodeSeed
            // 
            this.LabelNodeSeed.AutoSize = true;
            this.LabelNodeSeed.Location = new System.Drawing.Point(333, 19);
            this.LabelNodeSeed.Name = "LabelNodeSeed";
            this.LabelNodeSeed.Size = new System.Drawing.Size(127, 13);
            this.LabelNodeSeed.TabIndex = 18;
            this.LabelNodeSeed.Text = "Node Seed (0 is random):";
            // 
            // NumericNodeSeed
            // 
            this.NumericNodeSeed.Location = new System.Drawing.Point(463, 17);
            this.NumericNodeSeed.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumericNodeSeed.Name = "NumericNodeSeed";
            this.NumericNodeSeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumericNodeSeed.Size = new System.Drawing.Size(122, 20);
            this.NumericNodeSeed.TabIndex = 19;
            // 
            // TextBoxActiveNodeSeed
            // 
            this.TextBoxActiveNodeSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxActiveNodeSeed.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxActiveNodeSeed.Location = new System.Drawing.Point(77, 655);
            this.TextBoxActiveNodeSeed.Name = "TextBoxActiveNodeSeed";
            this.TextBoxActiveNodeSeed.ReadOnly = true;
            this.TextBoxActiveNodeSeed.Size = new System.Drawing.Size(63, 20);
            this.TextBoxActiveNodeSeed.TabIndex = 21;
            this.TextBoxActiveNodeSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelActiveNodeSeed
            // 
            this.LabelActiveNodeSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelActiveNodeSeed.AutoSize = true;
            this.LabelActiveNodeSeed.Location = new System.Drawing.Point(14, 658);
            this.LabelActiveNodeSeed.Name = "LabelActiveNodeSeed";
            this.LabelActiveNodeSeed.Size = new System.Drawing.Size(64, 13);
            this.LabelActiveNodeSeed.TabIndex = 20;
            this.LabelActiveNodeSeed.Text = "Node Seed:";
            // 
            // FormTravellingSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 682);
            this.Controls.Add(this.TextBoxActiveNodeSeed);
            this.Controls.Add(this.LabelActiveNodeSeed);
            this.Controls.Add(this.NumericNodeSeed);
            this.Controls.Add(this.LabelNodeSeed);
            this.Controls.Add(this.LabelPopulationSize);
            this.Controls.Add(this.NumericPopulationSize);
            this.Controls.Add(this.LabelNodeCount);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.ButtonMutate100);
            this.Controls.Add(this.NumericNodeCount);
            this.Controls.Add(this.ButtonMutate);
            this.Controls.Add(this.TextBoxGeneration);
            this.Controls.Add(this.ButtonMutate1000);
            this.Controls.Add(this.LabelGeneration);
            this.Controls.Add(this.ButtonMutate10);
            this.Controls.Add(this.LabelDistanceUnit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxDistance);
            this.Controls.Add(this.LabelDistance);
            this.MinimumSize = new System.Drawing.Size(810, 506);
            this.Name = "FormTravellingSalesman";
            this.Text = "Travelling Salesman";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericNodeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNodeSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Canvas CanvasGraph;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Label LabelDistance;
        private System.Windows.Forms.TextBox TextBoxDistance;
        private System.Windows.Forms.Label LabelCanvasWidth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelCanvasHeight;
        private System.Windows.Forms.Label LabelDistanceUnit;
        private System.Windows.Forms.Button ButtonMutate;
        private System.Windows.Forms.Button ButtonMutate10;
        private System.Windows.Forms.TextBox TextBoxGeneration;
        private System.Windows.Forms.Label LabelGeneration;
        private System.Windows.Forms.Button ButtonMutate100;
        private System.Windows.Forms.Button ButtonMutate1000;
        private System.Windows.Forms.NumericUpDown NumericNodeCount;
        private System.Windows.Forms.Label LabelNodeCount;
        private System.Windows.Forms.Label LabelPopulationSize;
        private System.Windows.Forms.NumericUpDown NumericPopulationSize;
        private System.Windows.Forms.Label LabelNodeSeed;
        private System.Windows.Forms.NumericUpDown NumericNodeSeed;
        private System.Windows.Forms.TextBox TextBoxActiveNodeSeed;
        private System.Windows.Forms.Label LabelActiveNodeSeed;
    }
}

