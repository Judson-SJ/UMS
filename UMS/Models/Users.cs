using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Models
{
    internal class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; }
        public int PhoneNO { get; set; }
        public string Address { get; set; }
        public string Role {  get; set; }
    }
}
