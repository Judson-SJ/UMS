using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Models;

namespace UMS.Controllers
{
    internal class AdminController
    {
        private readonly string _connectionString;
        public AdminController(string connectionString) => _connectionString = connectionString;

        public void AddAdmin(int userId, string name)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Admins (UserID, Name) VALUES (@userId, @name)", conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllAdmins()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
                    SELECT a.AdminID, a.Name, u.UserID, u.Name AS UserName, u.Role
                    FROM Admins a
                    INNER JOIN Users u ON u.UserID = a.UserID", conn);

                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateAdmin(int adminId, int userId, string name)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Admins SET Name = @name, AdminID = @adminId WHERE AdminID = @adminId", conn);
                cmd.Parameters.AddWithValue("@adminId", adminId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAdmin(int adminId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Admins WHERE AdminID = @adminId", conn);
                cmd.Parameters.AddWithValue("@adminId", adminId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
