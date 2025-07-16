using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class MarkController
    {
        private readonly string _connectionString;
        public MarkController(string connectionString) => _connectionString = connectionString;

        public void AddMark(int studentId, int examId, int score, string grade)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Marks (StudentID, ExamID, Score, Grade) VALUES (@studentId, @examId, @score, @grade)", conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@examId", examId);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Parameters.AddWithValue("@grade", grade);
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

        public void UpdateMark(int markId,int studentId,int examId, int score, string grade)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Marks SET Score = @score WHERE MarkID = @id", conn);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Parameters.AddWithValue("@id", markId);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@examId", examId);
                cmd.Parameters.AddWithValue("@grade", grade);
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