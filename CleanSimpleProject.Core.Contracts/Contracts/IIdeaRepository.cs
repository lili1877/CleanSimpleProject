using CleanSimpleProject.Core.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanSimpleProject.Core.Contracts.Contracts
{
    public interface IIdeaRepository
    {
        Task<IEnumerable<IdeaItem>> GetAllIdeaItemsByMainId(int ideamainId);
    }
}
