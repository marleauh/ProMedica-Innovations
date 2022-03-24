using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProMedica_Innovations.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddIdeaAsync(T Idea);
        Task<bool> UpdateIdeaAsync(T Idea);
        Task<bool> DeleteIdeaAsync(int Id);
        Task<T> GetIdeaAsync(int Id);
        Task<IEnumerable<T>> GetIdeasAsync(bool forceRefresh = false);
    }
}
