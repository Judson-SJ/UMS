using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Models
{
    internal class Subjects
    {
        public int SubjectId { get; set; }
        public int CourseID { get; set; }
        public int LectureId { get; set; }
        public string SubjectName { get; set; }
    }
}
