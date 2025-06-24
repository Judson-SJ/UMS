using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class LoginController
    {
        private readonly string _connectionString;
        public LoginController(string connectionString) => _connectionString = connectionString;

        public DataRow Login(string userId, string password)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Users WHERE UserID = @userId AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@password", password);

                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }
    }
}