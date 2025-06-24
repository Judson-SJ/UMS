using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class MarkController
    {
        private readonly string _connectionString;
        public MarkController(string connectionString) => _connectionString = connectionString;

        public void AddMark(int studentId, int examId, int score)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@studentId, @examId, @score)", conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@examId", examId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllMarks()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Marks", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateMark(int markId, int score)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Marks SET Score = @score WHERE MarkID = @id", conn);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Parameters.AddWithValue("@id", markId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMark(int markId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Marks WHERE MarkID = @id", conn);
                cmd.Parameters.AddWithValue("@id", markId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}