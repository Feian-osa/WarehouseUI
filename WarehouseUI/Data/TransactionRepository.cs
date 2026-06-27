using System.Data;
using Microsoft.Data.SqlClient;
using WarehouseUI.Models;

namespace WarehouseUI.Data
{
    public class TransactionRepository
    {
        public DataTable GetAll()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM Transactions ORDER BY TransactionDate DESC";
                var da = new SqlDataAdapter(sql, con);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Log(WarehouseUI.Models.Transaction txn)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Transactions
                    (ProductID, ProductName, CategoryName, Quantity, Price,
                     TransactionType, SupplierName, CustomerName, Remarks)
                    VALUES (@pid,@pname,@cname,@qty,@price,@type,@sup,@cust,@rem)";
                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", txn.ProductID);
                cmd.Parameters.AddWithValue("@pname", txn.ProductName);
                cmd.Parameters.AddWithValue("@cname", txn.CategoryName);
                cmd.Parameters.AddWithValue("@qty", txn.Quantity);
                cmd.Parameters.AddWithValue("@price", txn.Price);
                cmd.Parameters.AddWithValue("@type", txn.TransactionType);
                cmd.Parameters.AddWithValue("@sup", txn.SupplierName);
                cmd.Parameters.AddWithValue("@cust", txn.CustomerName);
                cmd.Parameters.AddWithValue("@rem", txn.Remarks);
                cmd.ExecuteNonQuery();
            }
        }


        // Also updates the product quantity
        public void StockAdjust(int productID, int qty, string type)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string op = type == "IN" ? "+" : "-";
                string sql = $"UPDATE Products SET Quantity = Quantity {op} @qty WHERE ProductID = @id";
                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@id", productID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}