using CleanSimpleProject.Core.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanSimpleProject.Core.Contracts.Contracts
{
    public interface IProjectRepository:IRepository<Project>
    {
        Task<IEnumerable<ProjectPic>> GetAllPics(int projectId);
        Task<IEnumerable<ProjectPic>> GetAllPicsByType(int projectId, byte type);
        Task<int> CountProjectPic(int projectId);
    }
}
