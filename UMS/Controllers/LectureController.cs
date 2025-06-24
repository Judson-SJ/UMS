using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Controllers
{
    internal class LectureController
    {
        private readonly string _connectionString;
        public LectureController(string connectionString) => _connectionString = connectionString;

        public void AddLecture(int lectureId, int userId, string name, string address, string phoneNo)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Lecturers (LectureID, UserID, Name, Address, PhoneNo) VALUES (@lectureId, @userId, @name, @address, @phoneNo)", conn);
                cmd.Parameters.AddWithValue("@lectureId", lectureId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllLecturers()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT l.LectureID, l.Name, l.Address, l.PhoneNo FROM Lecturers l INNER JOIN Users u ON u.UserID = l.UserID", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateLecture(int lectureId, int userId, string name, string address, string phoneNo)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Lecturers SET Name = @name, LectureID = @lectureId WHERE LectureID = @lectureId", conn);
                cmd.Parameters.AddWithValue("@lectureId", lectureId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLecture(int lectureId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Lecturers WHERE LectureID = @lectureId", conn);
                cmd.Parameters.AddWithValue("@lectureId", lectureId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
