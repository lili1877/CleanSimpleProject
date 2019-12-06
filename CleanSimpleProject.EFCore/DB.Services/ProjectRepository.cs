using CleanSimpleProject.Core.Contracts.Contracts;
using CleanSimpleProject.Core.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanSimpleProject.EFCore.DB.Services
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        private CleanContext _context=null;
        public ProjectRepository(CleanContext context): base(context)
        {
          
        }
        public async Task<IEnumerable<ProjectPic>> GetAllPics(int projectId)
        {
           return await _context.ProjectPics
                          .Where(o => o.ProjectId == projectId)
                          .ToListAsync();
                  
        }
        public async Task<IEnumerable<ProjectPic>> GetAllPicsByType(int projectId, byte type)
        {
           return await _context.ProjectPics
                           .Where(o => o.ProjectId == projectId && o.Type == type)
                           .ToListAsync();
        }
        public async Task<int> CountProjectPic(int projectId)
        {
           return await _context.ProjectPics
                          .Where(o => o.ProjectId == projectId)
                          .CountAsync();
        }
    }
}
