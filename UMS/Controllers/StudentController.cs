using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class StudentController
    {
        private readonly string _connectionString;
        public StudentController(string connectionString) => _connectionString = connectionString;

        public void AddStudent(string name, int courseId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Students (Name, CourseID) VALUES (@name, @courseId)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllStudents()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT s.StudentID, s.Name, c.CourseName FROM Students s INNER JOIN Courses c ON s.CourseID = c.CourseID", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateStudent(int studentId, string name, int courseId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Students SET Name = @name, CourseID = @courseId WHERE StudentID = @studentId", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Students WHERE StudentID = @studentId", conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}