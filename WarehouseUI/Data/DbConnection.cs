using Microsoft.Data.SqlClient;

namespace WarehouseUI.Data
{
    public static class DbConnection
    {
        private const string ConnStr =
            @"Server=(localdb)\MSSQLLocalDB;Database=WarehouseDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnStr);
        }
    }
}