using System;
using System.Collections.Generic;
using System.Text;

namespace FindMe.Tables
{
    public class RegUserTable
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
                     
    }
}
