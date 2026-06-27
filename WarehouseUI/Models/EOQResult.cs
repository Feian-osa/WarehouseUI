namespace WarehouseUI.Models
{
    public class EOQResult
    {
        public double EOQ { get; set; }
        public double OrdersPerYear { get; set; }
        public double HoldingCost { get; set; }
        public double OrderingCost { get; set; }
        public double TotalCost { get; set; }
    }
}