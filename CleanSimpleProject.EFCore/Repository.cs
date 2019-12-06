using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanSimpleProject.Core.Contracts.Contracts;
using Microsoft.EntityFrameworkCore;


namespace CleanSimpleProject.EFCore
{
      public class Repository<T> : IRepository<T> where T : class
    {
       
        private CleanContext _context=null;
        private DbSet<T> table = null;
        public Repository(CleanContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
       public IEnumerable<T> GetAllItems()
        {
            return table.ToList();
       }
        public int CountItems()
        {
            return table.ToList().Count();
       }
        public T GetItemId(object id)
        {
            return table.Find(id);
        }
        public void delItem(object id)
        {
            T exsiting = table.Find(id);
            table.Remove(exsiting);
        }
        public void AddItem(T obj)
        {
            table.Add(obj);
        }
        public void UpdateItem(T obj)
        {
            table.Update(obj);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}