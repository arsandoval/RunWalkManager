using System;

namespace RunWalkManager.Models
{
    public class Participant
    {
        /* Participant class, represent each member has the following properties
         * last name, first name, age, agreement (boolean)
         * phone number, email address, distance (1 mi/5k) type (walk/run)
         * special (military, student, child, autism)
        */
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public int identifier { get; }
        public int age { get; set; }
        public bool hasAgreed { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }
        public String eventLength { get; set; }
        public String type { get; set; }
        public String discount { get; set; }
    }
}
