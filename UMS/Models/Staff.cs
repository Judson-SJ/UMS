using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Models
{
    internal class Staff
    {
        public int StaffID { get; set; }
        public int UserID { get; set; }
        public string StaffName { get; set; }
        public string StaffAddress { get; set; }
        public string Role { get; set; }
    }
}
