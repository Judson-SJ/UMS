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
                        Role TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Admins (
                        AdminId INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        Name TEXT NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    );

                    CREATE TABLE IF NOT EXISTS Staff (
                        StaffId INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        PhoneNo TEXT NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Course TEXT NOT NULL,
                        PhoneNo TEXT NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    );

                    CREATE TABLE IF NOT EXISTS Lecturers (
                        LectureID INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        PhoneNo TEXT NOT NULL,
                        FOREIGN KEY (UserId) REFERENCES Users(UserId)
                    );

                    CREATE TABLE IF NOT EXISTS Rooms (
                        RoomId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Type TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Subjects (
                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        CourseId INTEGER,
                        LectureId INTEGER,
                        FOREIGN KEY (CourseId) REFERENCES Courses(CourseID),
                        FOREIGN KEY (LectureId) REFERENCES Lecturers(LectureID)
                    );

                    CREATE TABLE IF NOT EXISTS Exams (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        SubjectId INTEGER,
                        FOREIGN KEY (SubjectId) REFERENCES Subjects(SubjectID)
                    );

                    CREATE TABLE IF NOT EXISTS Marks (
                        MarksID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Score INTEGER NOT NULL,
                        Grade TEXT NOT NULL,
                        ExamId INTEGER,
                        StudentId INTEGER,
                        FOREIGN KEY (ExamId) REFERENCES Exams(ExamID),
                        FOREIGN KEY (StudentId) REFERENCES Students(StudentID)
                    );

                    CREATE TABLE IF NOT EXISTS Timetable (
                        TimeTableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectID INTEGER,
                        LectureID INTEGER,
                        RoomID INTEGER,
                        Date TEXT NOT NULL,
                        TimeSlot TEXT NOT NULL,
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
                        FOREIGN KEY (LectureID) REFERENCES Lecturers(LectureID)
                    );
                ";

                cmd.ExecuteNonQuery();
            }
        }

    }
}

