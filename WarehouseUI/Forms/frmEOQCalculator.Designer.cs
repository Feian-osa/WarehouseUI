namespace WarehouseUI.Forms
{
    partial class frmEOQCalculator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelFormHeader = new Panel();
            EOQcalc = new Label();
            panelInputsAndResults = new Panel();
            panelResultsCard = new Panel();
            TotalAnualCost = new TextBox();
            OrderingCost = new TextBox();
            HoldingCost = new TextBox();
            Orderperyear = new TextBox();
            EOQresult = new TextBox();
            label9 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label8 = new Label();
            label7 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnCalculateEOQ = new Button();
            numOrderingCost = new NumericUpDown();
            HoldingCostPerUnit = new NumericUpDown();
            numAnnualDemand = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            txtanualdemaand = new Label();
            EOQChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelFormHeader.SuspendLayout();
            panelInputsAndResults.SuspendLayout();
            panelResultsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderingCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HoldingCostPerUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnnualDemand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EOQChart).BeginInit();
            SuspendLayout();
            // 
            // panelFormHeader
            // 
            panelFormHeader.BackColor = Color.FromArgb(26, 28, 30);
            panelFormHeader.Controls.Add(EOQcalc);
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 0);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(800, 50);
            panelFormHeader.TabIndex = 0;
            // 
            // EOQcalc
            // 
            EOQcalc.AutoSize = true;
            EOQcalc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EOQcalc.ForeColor = Color.White;
            EOQcalc.Location = new Point(22, 19);
            EOQcalc.Name = "EOQcalc";
            EOQcalc.Size = new Size(137, 20);
            EOQcalc.TabIndex = 0;
            EOQcalc.Text = "📐 EOQ calculator";
            EOQcalc.Click += EOQcalc_Click;
            // 
            // panelInputsAndResults
            // 
            panelInputsAndResults.BackColor = Color.Transparent;
            panelInputsAndResults.Controls.Add(panelResultsCard);
            panelInputsAndResults.Controls.Add(btnCalculateEOQ);
            panelInputsAndResults.Controls.Add(numOrderingCost);
            panelInputsAndResults.Controls.Add(HoldingCostPerUnit);
            panelInputsAndResults.Controls.Add(numAnnualDemand);
            panelInputsAndResults.Controls.Add(label3);
            panelInputsAndResults.Controls.Add(label2);
            panelInputsAndResults.Controls.Add(txtanualdemaand);
            panelInputsAndResults.Dock = DockStyle.Left;
            panelInputsAndResults.Location = new Point(0, 50);
            panelInputsAndResults.Name = "panelInputsAndResults";
            panelInputsAndResults.Size = new Size(200, 400);
            panelInputsAndResults.TabIndex = 1;
            // 
            // panelResultsCard
            // 
            panelResultsCard.BackColor = Color.FromArgb(30, 35, 42);
            panelResultsCard.Controls.Add(TotalAnualCost);
            panelResultsCard.Controls.Add(OrderingCost);
            panelResultsCard.Controls.Add(HoldingCost);
            panelResultsCard.Controls.Add(Orderperyear);
            panelResultsCard.Controls.Add(EOQresult);
            panelResultsCard.Controls.Add(label9);
            panelResultsCard.Controls.Add(flowLayoutPanel2);
            panelResultsCard.Controls.Add(label8);
            panelResultsCard.Controls.Add(label7);
            panelResultsCard.Controls.Add(flowLayoutPanel1);
            panelResultsCard.Controls.Add(label6);
            panelResultsCard.Controls.Add(label5);
            panelResultsCard.Controls.Add(label4);
            panelResultsCard.Location = new Point(3, 224);
            panelResultsCard.Name = "panelResultsCard";
            panelResultsCard.Size = new Size(194, 173);
            panelResultsCard.TabIndex = 7;
            panelResultsCard.Paint += panelResultsCard_Paint;
            // 
            // TotalAnualCost
            // 
            TotalAnualCost.BackColor = Color.FromArgb(30, 35, 42);
            TotalAnualCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalAnualCost.ForeColor = Color.IndianRed;
            TotalAnualCost.Location = new Point(107, 149);
            TotalAnualCost.Name = "TotalAnualCost";
            TotalAnualCost.Size = new Size(84, 23);
            TotalAnualCost.TabIndex = 11;
            TotalAnualCost.TextChanged += TotalAnualCost_TextChanged;
            // 
            // OrderingCost
            // 
            OrderingCost.BackColor = Color.FromArgb(30, 35, 42);
            OrderingCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderingCost.ForeColor = Color.White;
            OrderingCost.Location = new Point(102, 114);
            OrderingCost.Name = "OrderingCost";
            OrderingCost.Size = new Size(84, 23);
            OrderingCost.TabIndex = 10;
            OrderingCost.TextChanged += OrderingCost_TextChanged;
            // 
            // HoldingCost
            // 
            HoldingCost.BackColor = Color.FromArgb(30, 35, 42);
            HoldingCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HoldingCost.ForeColor = Color.White;
            HoldingCost.Location = new Point(102, 85);
            HoldingCost.Name = "HoldingCost";
            HoldingCost.Size = new Size(84, 23);
            HoldingCost.TabIndex = 9;
            HoldingCost.TextChanged += HoldingCost_TextChanged;
            // 
            // Orderperyear
            // 
            Orderperyear.BackColor = Color.FromArgb(30, 35, 42);
            Orderperyear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orderperyear.ForeColor = Color.White;
            Orderperyear.Location = new Point(102, 43);
            Orderperyear.Name = "Orderperyear";
            Orderperyear.Size = new Size(84, 23);
            Orderperyear.TabIndex = 8;
            Orderperyear.TextChanged += Orderperyear_TextChanged;
            // 
            // EOQresult
            // 
            EOQresult.BackColor = Color.FromArgb(30, 35, 42);
            EOQresult.ForeColor = Color.White;
            EOQresult.Location = new Point(102, 14);
            EOQresult.Name = "EOQresult";
            EOQresult.Size = new Size(84, 23);
            EOQresult.TabIndex = 2;
            EOQresult.TextChanged += EOQresult_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(9, 152);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 7;
            label9.Text = "Total annual cost";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.DarkGray;
            flowLayoutPanel2.Location = new Point(3, 143);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 1);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(19, 110);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 6;
            label8.Text = "Ordering cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(17, 85);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 5;
            label7.Text = "Holding cost";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkGray;
            flowLayoutPanel1.Location = new Point(3, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 1);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(9, 51);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 4;
            label6.Text = "Orders per year\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(9, 22);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 3;
            label5.Text = "EOQ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(9, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 2;
            label4.Text = "RESULTS";
            // 
            // btnCalculateEOQ
            // 
            btnCalculateEOQ.AllowDrop = true;
            btnCalculateEOQ.BackgroundImageLayout = ImageLayout.None;
            btnCalculateEOQ.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnCalculateEOQ.FlatStyle = FlatStyle.Flat;
            btnCalculateEOQ.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculateEOQ.ForeColor = Color.White;
            btnCalculateEOQ.Location = new Point(12, 183);
            btnCalculateEOQ.Name = "btnCalculateEOQ";
            btnCalculateEOQ.Size = new Size(163, 35);
            btnCalculateEOQ.TabIndex = 2;
            btnCalculateEOQ.Text = "📐 Calculate EOQ";
            btnCalculateEOQ.UseVisualStyleBackColor = true;
            btnCalculateEOQ.Click += btnCalculateEOQ_Click;
            // 
            // numOrderingCost
            // 
            numOrderingCost.BackColor = Color.FromArgb(30, 35, 42);
            numOrderingCost.BorderStyle = BorderStyle.FixedSingle;
            numOrderingCost.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numOrderingCost.ForeColor = Color.White;
            numOrderingCost.Location = new Point(22, 83);
            numOrderingCost.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numOrderingCost.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numOrderingCost.Name = "numOrderingCost";
            numOrderingCost.Size = new Size(124, 27);
            numOrderingCost.TabIndex = 6;
            numOrderingCost.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // HoldingCostPerUnit
            // 
            HoldingCostPerUnit.BackColor = Color.FromArgb(30, 35, 42);
            HoldingCostPerUnit.BorderStyle = BorderStyle.FixedSingle;
            HoldingCostPerUnit.DecimalPlaces = 2;
            HoldingCostPerUnit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HoldingCostPerUnit.ForeColor = Color.White;
            HoldingCostPerUnit.Location = new Point(22, 136);
            HoldingCostPerUnit.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            HoldingCostPerUnit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            HoldingCostPerUnit.Name = "HoldingCostPerUnit";
            HoldingCostPerUnit.Size = new Size(124, 27);
            HoldingCostPerUnit.TabIndex = 5;
            HoldingCostPerUnit.Value = new decimal(new int[] { 2, 0, 0, 0 });
            HoldingCostPerUnit.ValueChanged += HoldingCostPerUnit_ValueChanged;
            // 
            // numAnnualDemand
            // 
            numAnnualDemand.BackColor = Color.FromArgb(30, 35, 42);
            numAnnualDemand.BorderStyle = BorderStyle.FixedSingle;
            numAnnualDemand.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAnnualDemand.ForeColor = Color.White;
            numAnnualDemand.Location = new Point(20, 30);
            numAnnualDemand.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numAnnualDemand.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAnnualDemand.Name = "numAnnualDemand";
            numAnnualDemand.Size = new Size(124, 27);
            numAnnualDemand.TabIndex = 2;
            numAnnualDemand.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numAnnualDemand.ValueChanged += numAnnualDemand_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 118);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 4;
            label3.Text = "Holding cost per unit (H)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 65);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 3;
            label2.Text = "Ordering cost per order (S)";
            // 
            // txtanualdemaand
            // 
            txtanualdemaand.AutoSize = true;
            txtanualdemaand.ForeColor = Color.White;
            txtanualdemaand.Location = new Point(22, 12);
            txtanualdemaand.Name = "txtanualdemaand";
            txtanualdemaand.Size = new Size(111, 15);
            txtanualdemaand.TabIndex = 2;
            txtanualdemaand.Text = "Annual demand (D)";
            txtanualdemaand.Click += label2_Click;
            // 
            // EOQChart
            // 
            EOQChart.BackColor = Color.FromArgb(18, 22, 26);
            chartArea3.AxisX.MajorGrid.LineColor = Color.FromArgb(40, 45, 53);
            chartArea3.AxisY.MajorGrid.LineColor = Color.FromArgb(40, 45, 53);
            chartArea3.BackColor = Color.Transparent;
            chartArea3.Name = "ChartArea1";
            EOQChart.ChartAreas.Add(chartArea3);
            EOQChart.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            EOQChart.Legends.Add(legend3);
            EOQChart.Location = new Point(200, 50);
            EOQChart.Name = "EOQChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.FromArgb(46, 204, 113);
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            EOQChart.Series.Add(series3);
            EOQChart.Size = new Size(600, 400);
            EOQChart.TabIndex = 2;
            EOQChart.Text = "chart1";
            EOQChart.Click += EOQChart_Click;
            // 
            // frmEOQCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 21);
            ClientSize = new Size(800, 450);
            Controls.Add(EOQChart);
            Controls.Add(panelInputsAndResults);
            Controls.Add(panelFormHeader);
            Name = "frmEOQCalculator";
            Text = "frmEOQCalculator";
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            panelInputsAndResults.ResumeLayout(false);
            panelInputsAndResults.PerformLayout();
            panelResultsCard.ResumeLayout(false);
            panelResultsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderingCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)HoldingCostPerUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnnualDemand).EndInit();
            ((System.ComponentModel.ISupportInitialize)EOQChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormHeader;
        private Label EOQcalc;
        private Panel panelInputsAndResults;
        private Label txtanualdemaand;
        private NumericUpDown numOrderingCost;
        private NumericUpDown HoldingCostPerUnit;
        private NumericUpDown numAnnualDemand;
        private Label label3;
        private Label label2;
        private Button btnCalculateEOQ;
        private Panel panelResultsCard;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox OrderingCost;
        private TextBox HoldingCost;
        private TextBox Orderperyear;
        private TextBox EOQresult;
        private System.Windows.Forms.DataVisualization.Charting.Chart EOQChart;
        private TextBox TotalAnualCost;
    }
}