using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using ProMedica_Innovations.Models;

namespace ProMedica_Innovations.Data
{
    public class IdeaDatabase
    {
        readonly SQLiteAsyncConnection database;

        public IdeaDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Idea>().Wait();
        }

        public Task<List<Idea>> GetIdeasAsync()
        {
            //Get all notes.
            return database.Table<Idea>().ToListAsync();
        }

        public Task<Idea> GetIdeaAsync(int id)
        {
            // Get a specific note.
            return database.Table<Idea>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveIdeaAsync(Idea idea)
        {
            if (idea.Id != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(idea);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(idea);
            }
        }

        public Task<int> DeleteIdeaAsync(Idea idea)
        {
            // Delete a note.
            return database.DeleteAsync(idea);
        }
    }
}