using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Controllers
{
    internal class StaffController
    {
        private readonly string _connectionString;
        public StaffController(string connectionString) => _connectionString = connectionString;

        public void AddStaff(int staffId, int userId, string name, string address, string phoneNo)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Staff (StaffID, UserID, Name, Address, PhoneNo) VALUES (@staffId, @userId, @name, @address, @phoneNo)", conn);
                cmd.Parameters.AddWithValue("@staffId", staffId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllStaff()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT s.StaffID, s.Name, s.Address, s.PhoneNo FROM Staff s INNER JOIN Users u ON u.UserID = s.UserID", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateStaff(int staffId, int userId, string name, string address, string phoneNo)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Staff SET Name = @name, StaffID = @staffId WHERE StaffID = @staffId", conn);
                cmd.Parameters.AddWithValue("@staffId", staffId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStaff(int staffId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Staff WHERE StaffID = @staffId", conn);
                cmd.Parameters.AddWithValue("@staffId", staffId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
