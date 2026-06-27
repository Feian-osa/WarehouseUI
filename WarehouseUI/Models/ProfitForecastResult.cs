namespace WarehouseUI.Models
{
    public class ProfitForecastResult
    {
        public int Month { get; set; }
        public double PredictedProfit { get; set; }
        public bool IsForecasted { get; set; }
    }
}


// false = actual, true = predicted