using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class TimetableController
    {
        private readonly string _connectionString;
        public TimetableController(string connectionString) => _connectionString = connectionString;

        public void AddTimetable(int subjectId, string timeSlot, int roomId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@subjectId, @timeSlot, @roomId)", conn);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.Parameters.AddWithValue("@timeSlot", timeSlot);
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllTimetables()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"SELECT t.TimetableID, s.SubjectName, t.TimeSlot, r.RoomName
                                              FROM Timetables t
                                              JOIN Subjects s ON t.SubjectID = s.SubjectID
                                              JOIN Rooms r ON t.RoomID = r.RoomID", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void DeleteTimetable(int timetableId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Timetables WHERE TimetableID = @id", conn);
                cmd.Parameters.AddWithValue("@id", timetableId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}