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
        /// <summary>
        /// get all pictures for specific project
        /// </summary>
        /// <param name="projectId">id of specific project</param>
        /// <returns>a list of all pictures for project with <paramref name="projectId"/></returns>
        public async Task<IEnumerable<ProjectPic>> GetAllPics(int projectId)
        {
           return await _context.ProjectPics
                          .Where(o => o.ProjectId == projectId)
                          .ToListAsync();
                  
        }
        /// <summary>
        /// get all pictures with specific type for example 2D or 3D for specific project and 
        /// </summary>
        /// <param name="projectId">id of specific project</param>
        /// <param name="type">determine the typeof pictures</param>
        /// <returns><para>a list of all pictures with specific type for project 
        /// with <paramref name="projectId"/>
        /// </para></returns>
        public async Task<IEnumerable<ProjectPic>> GetAllPicsByType(int projectId, byte type)
        {
           return await _context.ProjectPics
                           .Where(o => o.ProjectId == projectId && o.Type == type)
                           .ToListAsync();
        }
        /// <summary>
        /// get the number of all pictures for specific project
        /// </summary>
        /// <param name="projectId">id of specific project</param>
        /// <returns>an int value of the number of pictures for project with <paramref name="projectId"/></returns>
        public async Task<int> CountProjectPic(int projectId)
        {
           return await _context.ProjectPics
                          .Where(o => o.ProjectId == projectId)
                          .CountAsync();
        }
    }
}
