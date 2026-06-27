using System;

namespace WarehouseUI.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public string SupplierName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public DateTime TransactionDate { get; set; }
    }
}