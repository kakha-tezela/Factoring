using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FactoringService.Core.Domain;
using FactoringService.Core.Repositories;
using FactoringService.Persistence.Repositories;

namespace FactoringService.Persistence.Repositories
{
    public class RepresentivePeopleRepository : Repository<RepresentivePerson>, IRepresentivePersonRepository
    {
        public RepresentivePeopleRepository( DbContext context ) : base(context)
        {

        }
    }
}