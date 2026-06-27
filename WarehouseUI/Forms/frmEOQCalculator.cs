using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WarehouseUI.Services;
using WarehouseUI.Models;

namespace WarehouseUI.Forms
{
    public partial class frmEOQCalculator : Form
    {
        private readonly EOQCalculatorService _svc = new EOQCalculatorService();

        public frmEOQCalculator()
        {
            InitializeComponent();
            SetupChart();
        }

        private void SetupChart()
        {
            EOQChart.Series.Clear();
            EOQChart.ChartAreas.Clear();

            var area = new ChartArea("EOQArea");
            area.AxisX.Title = "Order Quantity (units)";
            area.AxisY.Title = "Total Cost (Rs)";
            area.AxisX.TitleFont = new Font("Segoe UI", 9);
            area.AxisY.TitleFont = new Font("Segoe UI", 9);
            area.BackColor = Color.FromArgb(30, 30, 30);
            area.AxisX.LabelStyle.ForeColor = Color.Silver;
            area.AxisY.LabelStyle.ForeColor = Color.Silver;
            area.AxisX.LineColor = Color.Gray;
            area.AxisY.LineColor = Color.Gray;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            EOQChart.ChartAreas.Add(area);

            // Cost curve series
            var curveSeries = new Series("TotalCost")
            {
                ChartType = SeriesChartType.Spline,
                Color = Color.SteelBlue,
                BorderWidth = 3,
                ChartArea = "EOQArea"
            };
            EOQChart.Series.Add(curveSeries);

            // EOQ point series
            var pointSeries = new Series("EOQPoint")
            {
                ChartType = SeriesChartType.Point,
                Color = Color.FromArgb(220, 53, 69),
                MarkerSize = 12,
                MarkerStyle = MarkerStyle.Circle,
                ChartArea = "EOQArea"
            };
            EOQChart.Series.Add(pointSeries);

            EOQChart.BackColor = Color.FromArgb(30, 30, 30);
            EOQChart.ForeColor = Color.White;
        }

        private void btnCalculateEOQ_Click(object sender, EventArgs e)
        {
            double D = (double)numAnnualDemand.Value;
            double S = (double)numOrderingCost.Value;
            double H = (double)HoldingCostPerUnit.Value;

            if (H <= 0)
            {
                MessageBox.Show("Holding cost per unit must be greater than 0.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (D <= 0 || S <= 0)
            {
                MessageBox.Show("Demand and ordering cost must be greater than 0.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EOQResult r = _svc.Calculate(D, S, H);

            // Fill result textboxes
            EOQresult.Text = r.EOQ.ToString("F2");
            Orderperyear.Text = r.OrdersPerYear.ToString("F2");
            HoldingCost.Text = $"Rs {r.HoldingCost:F2}";
            OrderingCost.Text = $"Rs {r.OrderingCost:F2}";
            TotalAnualCost.Text = $"Rs {r.TotalCost:F2}";

            // Draw cost curve
            EOQChart.Series["TotalCost"].Points.Clear();
            EOQChart.Series["EOQPoint"].Points.Clear();

            foreach (var (qty, cost) in _svc.GetCostCurvePoints(D, S, H, r.EOQ))
                EOQChart.Series["TotalCost"].Points.AddXY(Math.Round(qty, 2), Math.Round(cost, 2));

            // Red dot at EOQ minimum
            EOQChart.Series["EOQPoint"].Points.AddXY(
                Math.Round(r.EOQ, 2), Math.Round(r.TotalCost, 2));
        }

        // Leave empty
        private void label2_Click(object sender, EventArgs e) { }
        private void panelResultsCard_Paint(object sender, PaintEventArgs e) { }
        private void numAnnualDemand_ValueChanged(object sender, EventArgs e) { }
        private void numHoldingCost_ValueChanged(object sender, EventArgs e) { }
        private void HoldingCostPerUnit_ValueChanged(object sender, EventArgs e) { }
        private void EOQresult_TextChanged(object sender, EventArgs e) { }
        private void Orderperyear_TextChanged(object sender, EventArgs e) { }
        private void HoldingCost_TextChanged(object sender, EventArgs e) { }
        private void OrderingCost_TextChanged(object sender, EventArgs e) { }
        private void TotalAnualCost_TextChanged(object sender, EventArgs e) { }
        private void EOQChart_Click(object sender, EventArgs e) { }
        private void EOQcalc_Click(object sender, EventArgs e) { }
    }
}