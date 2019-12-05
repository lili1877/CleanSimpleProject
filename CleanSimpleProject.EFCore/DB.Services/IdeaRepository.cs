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
        public async Task<IEnumerable<IdeaItem>> GetAllIdeaItemsByMainId(int ideamainId)
        {
            return await _context.IdeaItems
                .Where(o => o.IdeaMainId== ideamainId)
                .ToListAsync();
        }
    }
}
