using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WarehouseUI.Data;
using WarehouseUI.Services;
using WarehouseUI.Models;

namespace WarehouseUI.Forms
{
    public partial class frmProfitPrediction : Form
    {
        private readonly SalesRepository _salesRepo = new SalesRepository();
        private readonly ProfitPredictionService _svc = new ProfitPredictionService();

        public frmProfitPrediction()
        {
            InitializeComponent();
            SetupChart();
        }

        private void SetupChart()
        {
            chartProfitForecast.Series.Clear();
            chartProfitForecast.ChartAreas.Clear();

            var area = new ChartArea("ProfitArea");
            area.AxisX.Title = "Month";
            area.AxisY.Title = "Profit (Rs)";
            area.AxisX.TitleFont = new Font("Segoe UI", 9);
            area.AxisY.TitleFont = new Font("Segoe UI", 9);
            area.BackColor = Color.FromArgb(30, 30, 30);
            area.AxisX.LabelStyle.ForeColor = Color.Silver;
            area.AxisY.LabelStyle.ForeColor = Color.Silver;
            area.AxisX.LineColor = Color.Gray;
            area.AxisY.LineColor = Color.Gray;
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            chartProfitForecast.ChartAreas.Add(area);

            // Actual profit line — solid blue
            var actualSeries = new Series("Actual")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.SteelBlue,
                BorderWidth = 3,
                ChartArea = "ProfitArea",
                LegendText = "Actual profit"
            };
            chartProfitForecast.Series.Add(actualSeries);

            // Forecast line — dashed orange
            var forecastSeries = new Series("Forecast")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Orange,
                BorderWidth = 2,
                BorderDashStyle = ChartDashStyle.Dash,
                ChartArea = "ProfitArea",
                LegendText = "Forecasted"
            };
            chartProfitForecast.Series.Add(forecastSeries);

            chartProfitForecast.BackColor = Color.FromArgb(30, 30, 30);
            chartProfitForecast.ForeColor = Color.White;
            chartProfitForecast.Legends[0].BackColor = Color.FromArgb(40, 40, 40);
            chartProfitForecast.Legends[0].ForeColor = Color.White;
        }

        private void btnRunForecast_Click(object sender, EventArgs e)
        {
            var dt = _salesRepo.GetMonthlySummary();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No sales data found in SalesHistory table.\n\n" +
                    "Add some records to SalesHistory in SSMS first:\n" +
                    "INSERT INTO SalesHistory (ProductID, SaleDate, UnitsSold, Revenue, Cost)\n" +
                    "VALUES (1, '2026-01-15', 10, 850000, 700000);",
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Build actual data list
            var actual = new List<(int month, double profit)>();
            foreach (System.Data.DataRow row in dt.Rows)
                actual.Add((Convert.ToInt32(row["Month"]),
                            Convert.ToDouble(row["Profit"])));

            int forecastMonths = (int)numForecastMonths.Value;
            List<ProfitForecastResult> results = _svc.Predict(actual, forecastMonths);

            // Update stat card labels
            double avgProfit = actual.Average(a => a.profit);
            double nextMonth = results.FirstOrDefault(r => r.IsForecasted)?.PredictedProfit ?? 0;
            double threeMonth = results.Where(r => r.IsForecasted)
                                         .Take(3)
                                         .Sum(r => r.PredictedProfit);

            label4.Text = $"Rs {avgProfit:N0}";
            label8.Text = $"Rs {nextMonth:N0}";
            label9.Text = $"Rs {threeMonth:N0}";

            // Draw chart
            chartProfitForecast.Series["Actual"].Points.Clear();
            chartProfitForecast.Series["Forecast"].Points.Clear();

            foreach (var r in results)
            {
                if (!r.IsForecasted)
                    chartProfitForecast.Series["Actual"].Points.AddXY(
                        r.Month, Math.Round(r.PredictedProfit, 2));
                else
                    chartProfitForecast.Series["Forecast"].Points.AddXY(
                        r.Month, Math.Round(r.PredictedProfit, 2));
            }
        }

        // Leave empty
        private void numForecastMonths_ValueChanged(object sender, EventArgs e) { }
        private void chartProfitForecast_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label10_Click_1(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
    }
}