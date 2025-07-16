using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class SubjectController
    {
        private readonly string _connectionString;
        public SubjectController(string connectionString) => _connectionString = connectionString;

        public void AddSubject(string name, int courseId, int lectureId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Subjects (Name, CourseId, LectureID) VALUES (@name, @courseId, @lectureId)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@lectureId", lectureId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllSubjects()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
                    SELECT s.SubjectID, s.Name AS Name,
                           c.Name AS Course,
                           l.Name AS Lecture
                    FROM Subjects s
                    JOIN Courses c ON s.CourseID = c.CourseID
                    JOIN Lecturers l ON s.LectureID = l.LectureID", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateSubject(int subjectId, string name, int courseId, int lectureId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Subjects SET Name = @name, CourseID = @courseId , LectureID = @lectureId WHERE SubjectID = @subjectId", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@lectureId", lectureId);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @subjectId", conn);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}