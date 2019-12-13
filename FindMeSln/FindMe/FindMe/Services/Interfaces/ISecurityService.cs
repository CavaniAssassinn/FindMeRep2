using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FindMe.Services.Interfaces
{
    public interface ISecurityService
    {
        Task<bool> Login(string Email, string Password);
        void LogOut();
    }
}
