using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProMedica_Innovations.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddIdeaAsync(T Idea);
        Task<bool> UpdateIdeaAsync(T Idea);
        Task<bool> DeleteIdeaAsync(string Id);
        Task<T> GetIdeaAsync(string Id);
        Task<IEnumerable<T>> GetIdeasAsync(bool forceRefresh = false);
    }
}
