using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FindMe.Models
{
    public class User
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "UserName should not be empty")]
        public string Username { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Email should not be empty")]
        public string Email { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Password should not be empty")]
        public string Password { get; set; }
    }
}
