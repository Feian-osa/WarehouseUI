namespace WarehouseUI.Models
{
    public class InventoryItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }
        public decimal UnitPrice { get; set; }
        public int AnnualDemand { get; set; }
        public decimal OrderingCost { get; set; }
        public decimal HoldingCostPerUnit { get; set; }
    }
}