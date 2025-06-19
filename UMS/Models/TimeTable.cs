using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Models
{
    internal class TimeTable
    {
        public int TimeTableID { get; set; }
        public int SubjectID { get; set; }
        public int RoomID { get; set; }
        public string TimeSlot { get; set; }

    }
}
