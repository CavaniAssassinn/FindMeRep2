using FindMe.Tables;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FindMe.Services.Interfaces
{
    public class Database 
    {
        
            readonly SQLiteAsyncConnection _database;

            public Database(string dbPath)
            {
                _database = new SQLiteAsyncConnection(dbPath);
                _database.CreateTableAsync<RegUserTable>().Wait();
            }

            public Task<List<RegUserTable>> GetRegUserTableAsync()
            {
                return _database.Table<RegUserTable>().ToListAsync();
            }

            public Task<int> SaveRegUserTableAsync(RegUserTable user)
            {
                return _database.InsertAsync(user);
            }
    }
}
