using System.Data;
using System.Data.SQLite;

namespace UMS.Controllers
{
    public class RoomController
    {
        private readonly string _connectionString;
        public RoomController(string connectionString) => _connectionString = connectionString;

        public void AddRoom(string name, string type)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllRooms()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Rooms", conn);
                var adapter = new SQLiteDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void DeleteRoom(int roomId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Rooms WHERE RoomID = @id", conn);
                cmd.Parameters.AddWithValue("@id", roomId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}