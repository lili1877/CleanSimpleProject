using CleanSimpleProject.Core.Contracts.Contracts;
using CleanSimpleProject.Core.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanSimpleProject.EFCore.DB.Services
{
    public class OfferRepository : Repository<Offer>, IOfferRepository
    {
        public OfferRepository(CleanContext context): base(context)
        {
          
        }
    }
}
