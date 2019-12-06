using CleanSimpleProject.Core.Contracts.Contracts;
using CleanSimpleProject.Core.Entities.Entities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CleanSimpleProject.EFCore.DB.Services
{
    public class IdeaRepository : Repository<IdeaMain>, IIdeaRepository
    {
        private CleanContext _context = null;
        public IdeaRepository(CleanContext context): base(context)
        {
          
        }
        /// <summary>
        /// returns all items for an idea
        /// </summary>
        /// <param name="ideamainId"> specific id of idea entity</param>
        /// <returns>a list of all ideaItems for idea with <paramref name="ideamainId"/></returns>
        public async Task<IEnumerable<IdeaItem>> GetAllIdeaItemsByMainId(int ideamainId)
        {
            return await _context.IdeaItems
                .Where(o => o.IdeaMainId== ideamainId)
                .ToListAsync();
        }
    }
}
