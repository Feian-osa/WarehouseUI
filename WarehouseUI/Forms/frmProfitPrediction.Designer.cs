namespace WarehouseUI.Forms
{
    partial class frmProfitPrediction
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelFormHeader = new Panel();
            label1 = new Label();
            panelControls = new Panel();
            btnRunForecast = new Button();
            numForecastMonths = new NumericUpDown();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            chartProfitForecast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelFormHeader.SuspendLayout();
            panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numForecastMonths).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProfitForecast).BeginInit();
            SuspendLayout();
            // 
            // panelFormHeader
            // 
            panelFormHeader.BackColor = Color.FromArgb(26, 28, 30);
            panelFormHeader.Controls.Add(label1);
            panelFormHeader.Dock = DockStyle.Top;
            panelFormHeader.Location = new Point(0, 0);
            panelFormHeader.Name = "panelFormHeader";
            panelFormHeader.Size = new Size(802, 50);
            panelFormHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "📈 Profit prediction";
            label1.Click += label1_Click;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.Transparent;
            panelControls.Controls.Add(btnRunForecast);
            panelControls.Controls.Add(numForecastMonths);
            panelControls.Controls.Add(label2);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 50);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(802, 60);
            panelControls.TabIndex = 1;
            // 
            // btnRunForecast
            // 
            btnRunForecast.FlatAppearance.BorderColor = Color.FromArgb(85, 85, 85);
            btnRunForecast.FlatStyle = FlatStyle.Flat;
            btnRunForecast.ForeColor = Color.White;
            btnRunForecast.Location = new Point(305, 15);
            btnRunForecast.Name = "btnRunForecast";
            btnRunForecast.Size = new Size(110, 24);
            btnRunForecast.TabIndex = 2;
            btnRunForecast.Text = "▶️ Run Forecast";
            btnRunForecast.UseVisualStyleBackColor = true;
            btnRunForecast.Click += btnRunForecast_Click;
            // 
            // numForecastMonths
            // 
            numForecastMonths.BackColor = Color.FromArgb(30, 35, 42);
            numForecastMonths.BorderStyle = BorderStyle.FixedSingle;
            numForecastMonths.ForeColor = Color.White;
            numForecastMonths.Location = new Point(151, 16);
            numForecastMonths.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numForecastMonths.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numForecastMonths.Name = "numForecastMonths";
            numForecastMonths.Size = new Size(120, 23);
            numForecastMonths.TabIndex = 1;
            numForecastMonths.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numForecastMonths.ValueChanged += numForecastMonths_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 0;
            label2.Text = "Forecast months ahead:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 110);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Green;
            label5.Location = new Point(30, 78);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 6;
            label5.Text = "+12% vs last period";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GradientInactiveCaption;
            label4.Location = new Point(30, 37);
            label4.Name = "label4";
            label4.Size = new Size(80, 30);
            label4.TabIndex = 5;
            label4.Text = "Rs 42K";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(30, 22);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 4;
            label3.Text = "AVG MONTHLY PROFIT";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(278, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 110);
            panel2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Green;
            label10.Location = new Point(27, 78);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 8;
            label10.Text = "Upward trend";
            label10.Click += label10_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.GradientInactiveCaption;
            label8.Location = new Point(27, 46);
            label8.Name = "label8";
            label8.Size = new Size(80, 30);
            label8.TabIndex = 7;
            label8.Text = "Rs 51K";
            label8.Click += label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(27, 22);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 7;
            label6.Text = "Next month forecast";
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(536, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 110);
            panel3.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(32, 78);
            label11.Name = "label11";
            label11.Size = new Size(96, 15);
            label11.TabIndex = 9;
            label11.Text = "Linear regression";
            label11.Click += label11_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.GradientInactiveCaption;
            label9.Location = new Point(31, 46);
            label9.Name = "label9";
            label9.Size = new Size(80, 30);
            label9.TabIndex = 8;
            label9.Text = "Rs 51K";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(31, 22);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 8;
            label7.Text = "3-month outlook";
            label7.Click += label7_Click;
            // 
            // chartProfitForecast
            // 
            chartProfitForecast.BackColor = Color.FromArgb(18, 22, 26);
            chartArea2.AxisX.LabelStyle.ForeColor = Color.DarkGray;
            chartArea2.AxisX.MajorGrid.LineColor = Color.FromArgb(37, 42, 48);
            chartArea2.AxisY.LabelStyle.ForeColor = Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineColor = Color.FromArgb(37, 42, 48);
            chartArea2.BackColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartProfitForecast.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartProfitForecast.Legends.Add(legend2);
            chartProfitForecast.Location = new Point(12, 242);
            chartProfitForecast.Name = "chartProfitForecast";
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.FromArgb(230, 126, 34);
            series3.Legend = "Legend1";
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = Color.FromArgb(52, 152, 219);
            series4.Legend = "Legend1";
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series1";
            chartProfitForecast.Series.Add(series3);
            chartProfitForecast.Series.Add(series4);
            chartProfitForecast.Size = new Size(764, 325);
            chartProfitForecast.TabIndex = 10;
            chartProfitForecast.Text = "chart1";
            chartProfitForecast.Click += chartProfitForecast_Click;
            // 
            // frmProfitPrediction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 21);
            ClientSize = new Size(802, 579);
            Controls.Add(chartProfitForecast);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelControls);
            Controls.Add(panelFormHeader);
            Name = "frmProfitPrediction";
            Text = "frmProfitPrediction";
            panelFormHeader.ResumeLayout(false);
            panelFormHeader.PerformLayout();
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numForecastMonths).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartProfitForecast).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormHeader;
        private Label label1;
        private Panel panelControls;
        private NumericUpDown numForecastMonths;
        private Label label2;
        private Button btnRunForecast;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label label8;
        private Label label6;
        private Label label9;
        private Label label7;
        private Label label10;
        private Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProfitForecast;
    }
}