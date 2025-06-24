using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class SubjectController
    {
        private readonly string _connectionString;
        public SubjectController(string connectionString) => _connectionString = connectionString;

        public void AddSubject(string name, int courseId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectName, CourseID) VALUES (@name, @courseId)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllSubjects()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Subjects", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateSubject(int subjectId, string name, int courseId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Subjects SET SubjectName = @name, CourseID = @courseId WHERE SubjectID = @subjectId", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@SubjectId", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @id", conn);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}