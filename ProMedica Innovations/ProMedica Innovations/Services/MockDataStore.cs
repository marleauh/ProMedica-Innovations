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
                new Idea { Id = Guid.NewGuid().ToString(), FirstName = "Hunter", LastName = "Marleau", Email = "marleauh@findlay.edu", Phone = "4196019566", Description = "Test input", Availability = "Now", Referral = "Espyn", Employee = false},
                //new Idea { Id = Guid.NewGuid().ToString(), FirstName = "Hunter", LastName = "Marleau", Email = "marleauh@findlay.edu", Phone = "4196019566", Description = "Test input", Availability = "Now", Referral = "Espyn", Employee = false},
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

        public async Task<bool> DeleteIdeaAsync(string id)
        {
            var oldIdea = ideas.Where((Idea arg) => arg.Id == id).FirstOrDefault();
            ideas.Remove(oldIdea);

            return await Task.FromResult(true);
        }

        public async Task<Idea> GetIdeaAsync(string id)
        {
            return await Task.FromResult(ideas.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Idea>> GetIdeasAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(ideas);
        }
    }
}