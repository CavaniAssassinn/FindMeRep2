using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindMe.Models
{
    public  class Confirmation
    {
        public class UserConfirmation : AbstractValidator<User>
        {
            public UserConfirmation()
            {
                RuleFor(x => x.Username).NotNull().Length(10, 20);
                RuleFor(x => x.Password).NotNull().Length(5, 15);
                RuleFor(x => x.Email).NotNull().EmailAddress();
            }
        }
    }
}
