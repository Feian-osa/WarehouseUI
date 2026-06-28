using Microsoft.Data.SqlClient;

namespace WarehouseUI.Data
{
    public class UserRepository
    {
        public bool ValidateLogin(string username, string password)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Username=@u AND PasswordHash=@p";
                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool UsernameExists(string username)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Username=@u";
                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", username);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public void Register(string username, string password, string fullName)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Users (Username, PasswordHash, FullName, Role)
                               VALUES (@u, @p, @fn, 'Staff')";
                var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@fn", fullName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}