using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class ExamController
    {
        private readonly string _connectionString;
        public ExamController(string connectionString) => _connectionString = connectionString;

        public void AddExam(string name, int subjectId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Exams (Name, SubjectID) VALUES (@name, @subjectId)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllExams()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Exams", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateExam(int examId, string name, int subjectId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Exams SET ExamName = @name, SubjectID = @subjectId WHERE ExamID = @id", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.Parameters.AddWithValue("@id", examId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteExam(int examId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Exams WHERE ExamID = @id", conn);
                cmd.Parameters.AddWithValue("@id", examId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}