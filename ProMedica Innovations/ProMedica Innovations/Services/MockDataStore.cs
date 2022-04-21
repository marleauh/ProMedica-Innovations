using ProMedica_Innovations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProMedica_Innovations.Services
{
    public class MockDataStore : IDataStore<Idea>
    {
        readonly List<Idea> ideas;

        public MockDataStore()
        {
            ideas = new List<Idea>()
            {
                new Idea { Id = Guid.NewGuid().GetHashCode(), FirstName = "Hunter", LastName = "Marleau", InvEmail = "marleauh@findlay.edu", Phone = "4196019566", Description = "Test input", Availability = "Now", Referral = "Espyn", Employee = false},
                // can put more test data here for better representation of app function. Follow the layout above.
            };
        }

        public async Task<bool> AddIdeaAsync(Idea idea)
        {
            ideas.Add(idea);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateIdeaAsync(Idea idea)
        {
            var oldIdea = ideas.Where((Idea arg) => arg.Id == idea.Id).FirstOrDefault();
            ideas.Remove(oldIdea);
            ideas.Add(idea);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteIdeaAsync(int id)
        {
            var oldIdea = ideas.Where((Idea arg) => arg.Id == id).FirstOrDefault();
            ideas.Remove(oldIdea);

            return await Task.FromResult(true);
        }

        public async Task<Idea> GetIdeaAsync(int id)
        {
            return await Task.FromResult(ideas.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Idea>> GetIdeasAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(ideas);
        }
    }
}