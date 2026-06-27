using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseUI.Models;

namespace WarehouseUI.Services
{
    public class ProfitPredictionService
    {
        // actualProfits: list of (month, profit) from SalesHistory
        // forecastMonths: how many future months to predict
        public List<ProfitForecastResult> Predict(
            List<(int month, double profit)> actual, int forecastMonths)
        {
            var result = new List<ProfitForecastResult>();

            // Add actual data points
            foreach (var a in actual)
                result.Add(new ProfitForecastResult
                { Month = a.month, PredictedProfit = a.profit, IsForecasted = false });

            // Linear regression
            double[] x = actual.Select(a => (double)a.month).ToArray();
            double[] y = actual.Select(a => a.profit).ToArray();
            var (slope, intercept) = LinearRegression(x, y);

            int lastMonth = actual.Max(a => a.month);
            for (int i = 1; i <= forecastMonths; i++)
            {
                int m = lastMonth + i;
                result.Add(new ProfitForecastResult
                { Month = m, PredictedProfit = slope * m + intercept, IsForecasted = true });
            }
            return result;
        }

        private (double slope, double intercept) LinearRegression(double[] x, double[] y)
        {
            int n = x.Length;
            double sumX = x.Sum();
            double sumY = y.Sum();
            double sumXY = x.Zip(y, (a, b) => a * b).Sum();
            double sumX2 = x.Sum(a => a * a);
            double slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            return (slope, (sumY - slope * sumX) / n);
        }
    }
}