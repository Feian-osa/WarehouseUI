using System.Data;
using Microsoft.Data.SqlClient;

namespace WarehouseUI.Data
{
    public class SalesRepository
    {
        public DataTable GetMonthlySummary()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"
                    SELECT MONTH(SaleDate)          AS Month,
                           SUM(Revenue)             AS Revenue,
                           SUM(Cost)                AS Cost,
                           SUM(Revenue - Cost)      AS Profit
                    FROM SalesHistory
                    WHERE YEAR(SaleDate) = YEAR(GETDATE())
                    GROUP BY MONTH(SaleDate)
                    ORDER BY Month";
                var da = new SqlDataAdapter(sql, con);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}