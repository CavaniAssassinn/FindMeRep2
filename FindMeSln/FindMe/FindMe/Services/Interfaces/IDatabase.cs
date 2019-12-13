using FindMe.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FindMe.Services.Interfaces
{
    
    
        public interface IDatabase
        {
            Task<int> SaveItemAsync(User info);
            Task<List<User>> GetAllInformationData();
            Task<User> GetPeopleByEmail(string Email);

        }
    
}
