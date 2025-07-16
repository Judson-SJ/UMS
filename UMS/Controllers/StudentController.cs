using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class StudentController
    {
        private readonly string _connectionString;
        public StudentController(string connectionString) => _connectionString = connectionString;

        public void AddStudent(int userId, string name, string address, string course, string phoneNo)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Students (UserId, Name, Address, Course, PhoneNo) VALUES (@userId, @name, @address, @course, @phoneNo)", conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllStudents()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
            SELECT 
                s.StudentID, 
                s.UserID, 
                s.Name, 
                s.Address, 
                s.Course, 
                s.PhoneNo 
            FROM Students s
            INNER JOIN Users u ON u.UserID = s.UserID", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateStudent(int studentId,int userId, string name,string address, string course, string phoneNo)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Students SET Name = @name, Address = @address, Course = @course, PhoneNo = @phoneNo WHERE StudentID = @studentId", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
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