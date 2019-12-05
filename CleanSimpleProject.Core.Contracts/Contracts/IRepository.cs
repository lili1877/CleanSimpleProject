using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanSimpleProject.Core.Contracts.Contracts
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAllItems();
        int CountItems();
        T GetItemId(object id);
        void delItem(object id);
        void AddItem(T obj);
        void UpdateItem(T obj);
        Task<bool> SaveChangesAsync();
    }
}
