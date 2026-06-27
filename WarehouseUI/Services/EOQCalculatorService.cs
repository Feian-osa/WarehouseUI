using System;
using WarehouseUI.Models;

namespace WarehouseUI.Services
{
    public class EOQCalculatorService
    {
        // D = Annual Demand, S = Ordering Cost, H = Holding Cost per unit
        public EOQResult Calculate(double D, double S, double H)
        {
            double eoq = Math.Sqrt((2 * D * S) / H);
            double ordersYear = D / eoq;
            double holdCost = (eoq / 2) * H;
            double ordCost = ordersYear * S;

            return new EOQResult
            {
                EOQ = eoq,
                OrdersPerYear = ordersYear,
                HoldingCost = holdCost,
                OrderingCost = ordCost,
                TotalCost = holdCost + ordCost
            };
        }

        // Returns (qty, totalCost) pairs for drawing the U-curve on the chart
        public (double qty, double cost)[] GetCostCurvePoints(double D, double S, double H, double eoq)
        {
            var result = new (double, double)[100];
            double step = (eoq * 3) / 100;
            for (int i = 0; i < 100; i++)
            {
                double q = step * (i + 1);
                double tc = (q / 2) * H + (D / q) * S;
                result[i] = (q, tc);
            }
            return result;
        }
    }
}