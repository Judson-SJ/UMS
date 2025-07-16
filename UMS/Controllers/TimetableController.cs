using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class TimetableController
    {
        private readonly string _connectionString;

        public TimetableController(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddTimetable(int subjectId, int lectureId, string date, string timeSlot, int roomId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"INSERT INTO Timetable 
                    (SubjectID, LectureID, Date, TimeSlot, RoomID) 
                    VALUES 
                    (@subjectId, @lectureId, @date, @timeSlot, @roomId)", conn);

                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.Parameters.AddWithValue("@lectureId", lectureId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@timeSlot", timeSlot);
                cmd.Parameters.AddWithValue("@roomId", roomId);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTimetable(int timeTableId, int subjectId, int lectureId, string date, string timeSlot, int roomId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"UPDATE Timetable 
                    SET SubjectID = @subjectId, LectureID = @lectureId, Date = @date, 
                        TimeSlot = @timeSlot, RoomID = @roomId 
                    WHERE TimeTableID = @timeTableId", conn);

                cmd.Parameters.AddWithValue("@timeTableId", timeTableId);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.Parameters.AddWithValue("@lectureId", lectureId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@timeSlot", timeSlot);
                cmd.Parameters.AddWithValue("@roomId", roomId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    throw new SQLiteException("No timetable found with the given ID to update.");
            }
        }

        public void DeleteTimetable(int timeTableId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Timetable WHERE TimeTableID = @TimeTableId", conn);
                cmd.Parameters.AddWithValue("@TimeTableId", timeTableId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    throw new SQLiteException("No timetable found with the given ID to delete.");
            }
        }

        public DataTable GetAllTimetables()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var query = @"
                    SELECT 
                        t.TimeTableID,
                        s.SubjectID,
                        l.LectureID,
                        r.RoomID,
                        s.Name,
                        l.Name AS LecturerName,
                        r.Name AS RoomName,
                        t.Date,
                        t.TimeSlot
                    FROM Timetable t
                    JOIN Subjects s ON t.SubjectID = s.SubjectID
                    JOIN Lecturers l ON t.LectureID = l.LectureID
                    JOIN Rooms r ON t.RoomID = r.RoomID";

                var cmd = new SQLiteCommand(query, conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}