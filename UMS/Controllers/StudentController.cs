using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class StudentController
    {
        private readonly string _connectionString;
        public StudentController(string connectionString) => _connectionString = connectionString;

        public void AddStudent(string name, string course)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Students (Name, Course) VALUES (@name, @course)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllStudents()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT StudentID, Name, Course FROM Students", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateStudent(int studentId, string name, string course)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Students SET Name = @name, Course = @course WHERE StudentID = @studentId", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@course", course);
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