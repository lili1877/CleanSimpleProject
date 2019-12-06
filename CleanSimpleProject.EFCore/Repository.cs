using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanSimpleProject.Core.Contracts.Contracts;
using Microsoft.EntityFrameworkCore;


namespace CleanSimpleProject.EFCore
{
    /// <summary>
    /// Main generic repository to do main work with database
    /// <list type="bullet">
    /// <item>GetAllItems </item>
    /// <item>CountItems </item>
    /// <item>GetItemId </item>
    /// <item>delItem </item>
    /// <item>AddItem </item>
    /// <item>UpdateItem </item>
    /// </list>
    /// </summary>
    /// <param name="CleanContext" >is a refrence of mainContext</param>
    /// <param name="table" >is a temprory container for doing operation</param>
    /// <typeparam name="T">T is an Entity</typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        private CleanContext _context=null;
        private DbSet<T> table = null;
        public Repository(CleanContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        /// <summary>
        /// getting all records for object T
        /// </summary>
        /// <returns> determine a list of all records</returns>
       public IEnumerable<T> GetAllItems()
       {
             return table.ToList();
       }
        /// <summary>
        /// get count for all existing records in a Entity
        /// </summary>
        /// <returns>return the number of records</returns>
        public int CountItems()
        {
            return table.ToList().Count();
        }
        /// <summary>
        /// get one record with special id
        /// </summary>
        /// <param name="id">determine special id</param>
        /// <returns>return one record with type T</returns>
        public T GetItemId(object id)
        {
            return table.Find(id);
        }
        /// <summary>
        /// delete one record with special id
        /// </summary>
        /// <param name="id">determine special id</param>
        public void delItem(object id)
        {
            T exsiting = table.Find(id);
            table.Remove(exsiting);
        }
        /// <summary>
        /// add a record with type T
        /// </summary>
        /// <param name="obj">an Entity</param>
        public void AddItem(T obj)
        {
            table.Add(obj);
        }
        /// <summary>
        /// add a record with type T
        /// </summary>
        /// <param name="obj">an Entity</param>
        public void UpdateItem(T obj)
        {
            table.Update(obj);
        }
        /// <summary>
        /// save changes in database
        /// </summary>
        /// <returns>true if can save changes,otherwise false </returns>
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}