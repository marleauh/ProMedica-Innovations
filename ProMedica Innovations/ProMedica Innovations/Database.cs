using ProMedica_Innovations.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProMedica_Innovations
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Idea>();
        }

        public Task<List<Idea>> GetIdeaAsync()
        {
            return _database.Table<Idea>().ToListAsync();
        }

        public Task<int> SaveIdeaAsync(Idea idea)
        {
            return _database.InsertAsync(idea);
        }
    }
}
