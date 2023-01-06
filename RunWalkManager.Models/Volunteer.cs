using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunWalkManager.Models
{
    public class Volunteer
    {
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public int identifier { get; }
        public int age { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }
        public String address { get; set; }
    }
}
