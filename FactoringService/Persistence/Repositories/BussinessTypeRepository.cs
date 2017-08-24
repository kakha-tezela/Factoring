using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FactoringService.Core.Domain;
using FactoringService.Core.Repositories;


namespace FactoringService.Persistence.Repositories
{
    public class BussinessTypeRepository : Repository<BussinessType>, IBussinessTypeRepository
    {
        public BussinessTypeRepository( DbContext context ) : base(context)
        {
        }
    }
}