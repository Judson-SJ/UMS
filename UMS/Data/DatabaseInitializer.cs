using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Data
{
    internal class DatabaseInitializer
    {
        public static void CreateTables()
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Password TEXT NOT NULL,
                        Name TEXT NOT NULL,
                        Role TEXT NOT NULL,
                    );
                    CREATE TABLE IF NOT EXISTS Admins (
                        AdminId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(UserId)

                    );
                    CREATE TABLE IF NOT EXISTS Staff (
                        StaffId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        PhoneNo TEXT NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Course TEXT NOT NULL,
                        PhoneNo TEXT NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    );

                    CREATE TABLE IF NOT EXISTS Lecturers (
                        LectureID INTEGER,PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        PhoneNo TEXT NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    );

                    CREATE TABLE IF NOT EXISTS Rooms (
                        RoomId INTEGER,PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Type TEXT NOT NULL,
                    );
                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER,PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                    );
                    CREATE TABLE IF NOT EXISTS Subjects (
                        SubjectID INTEGER,PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        FOREIGN KEY (CourseId) REFERENCES Courses(CourseId),
                        FOREIGN KEY (LectureId) REFERENCES Lecturers(LectureId)
                    );
                    CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER,PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectId)
                    );       
                    CREATE TABLE IF NOT EXISTS Marks (
                        MarksID INTEGER,PRIMARY KEY AUTOINCREMENT,
                        Score INTEGER NOT NULL,
                        Grade TEXT NOT NULL,
                        FOREIGN KEY (ExamId) REFERENCES Exams(ExamId),
                        FOREIGN KEY (StudentId) REFERENCES Students(StudentId)
                    );
                    CREATE TABLE IF NOT EXISTS TimeTable (
                        TimeTableID INTEGER,PRIMARY KEY AUTOINCREMENT,
                        TimeSlot TEXT NOT NULL,
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectId),
                        FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId)
                    );
";

                cmd.ExecuteNonQuery();
            }
        }

    }
}

