using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProMedica_Innovations.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T Idea);
        Task<bool> UpdateItemAsync(T Idea);
        Task<bool> DeleteItemAsync(string Id);
        Task<T> GetItemAsync(string Id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
