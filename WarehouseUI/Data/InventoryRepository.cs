using System.Data;
using Microsoft.Data.SqlClient;
using WarehouseUI.Models;

namespace WarehouseUI.Data
{
    public class InventoryRepository
    {
        // Returns all products as a DataTable (for DataGridView binding)
        public DataTable GetAll()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"SELECT p.ProductID, p.ProductName,
                                      c.CategoryName, p.Quantity,
                                      p.ReorderLevel, p.UnitPrice
                               FROM Products p
                               JOIN Categories c ON p.CategoryID = c.CategoryID";
                var da = new SqlDataAdapter(sql, con);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable Search(string keyword)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"SELECT p.ProductID, p.ProductName,
                                      c.CategoryName, p.Quantity,
                                      p.ReorderLevel, p.UnitPrice
                               FROM Products p
                               JOIN Categories c ON p.CategoryID = c.CategoryID
                               WHERE p.ProductName LIKE @kw OR c.CategoryName LIKE @kw";
                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Add(InventoryItem item)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Products
                    (ProductName, CategoryID, Quantity, ReorderLevel, UnitPrice,
                     AnnualDemand, OrderingCost, HoldingCostPerUnit)
                    VALUES (@name,@cat,@qty,@rl,@price,@demand,@oc,@hc)";
                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", item.ProductName);
                cmd.Parameters.AddWithValue("@cat", item.CategoryID);
                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                cmd.Parameters.AddWithValue("@rl", item.ReorderLevel);
                cmd.Parameters.AddWithValue("@price", item.UnitPrice);
                cmd.Parameters.AddWithValue("@demand", item.AnnualDemand);
                cmd.Parameters.AddWithValue("@oc", item.OrderingCost);
                cmd.Parameters.AddWithValue("@hc", item.HoldingCostPerUnit);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(InventoryItem item)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"UPDATE Products SET
                    ProductName=@name, CategoryID=@cat, Quantity=@qty,
                    ReorderLevel=@rl, UnitPrice=@price
                    WHERE ProductID=@id";
                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", item.ProductName);
                cmd.Parameters.AddWithValue("@cat", item.CategoryID);
                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                cmd.Parameters.AddWithValue("@rl", item.ReorderLevel);
                cmd.Parameters.AddWithValue("@price", item.UnitPrice);
                cmd.Parameters.AddWithValue("@id", item.ProductID);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int productID)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand(
                    "DELETE FROM Products WHERE ProductID=@id", con);
                cmd.Parameters.AddWithValue("@id", productID);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetCategories()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                var da = new SqlDataAdapter("SELECT * FROM Categories", con);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAllForDashboard()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"SELECT p.ProductName, c.CategoryName,
                                      p.Quantity, p.ReorderLevel,
                                      CASE WHEN p.Quantity <= 0 THEN 'Out of Stock'
                                           WHEN p.Quantity <= p.ReorderLevel THEN 'Low'
                                           ELSE 'OK' END AS Status
                               FROM Products p
                               JOIN Categories c ON p.CategoryID = c.CategoryID";
                var da = new SqlDataAdapter(sql, con);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int GetTotalProducts()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM Products", con);
                return (int)cmd.ExecuteScalar();
            }
        }

        public int GetLowStockCount()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Products WHERE Quantity <= ReorderLevel", con);
                return (int)cmd.ExecuteScalar();
            }
        }

        public decimal GetTotalStockValue()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                var cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(Quantity * UnitPrice), 0) FROM Products", con);
                return (decimal)cmd.ExecuteScalar();
            }
        }
    }
}