using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Models
{
    internal class Students
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string Course { get; set; }
    }
}
