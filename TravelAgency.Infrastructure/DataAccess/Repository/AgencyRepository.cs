using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Domain.Entities;
using TravelAgency.Infrastructure.Common.Utilities;
using TravelAgency.Infrastructure.DataAccess.IRepository;

namespace TravelAgency.Infrastructure.DataAccess.Repository
{
    public class AgencyRepository:GenericRepository<Agency>, IAgencyRepository
    {
        public AgencyRepository(TravelAgencyContext context):base(context)
        {
            
        }
        
<<<<<<< HEAD
<<<<<<< HEAD
        public Agency GetById(Agency elementId)
        {
            return  entity.Find(elementId)!;
        }
=======
       
>>>>>>> master
=======
       
>>>>>>> 67c808a2e2f44d7d88cebfc9cef18cf136ae4f79
    }
}