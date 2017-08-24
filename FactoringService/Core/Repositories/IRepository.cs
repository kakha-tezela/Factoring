using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace FactoringService.Core.Repositories
{
    // General Interface That Includes Common Operations For All Entities ( Get, Add, Remove ... )
    public interface IRepository<Tentity> where Tentity : class
    {
        Tentity GetById(int Id);
        IEnumerable<Tentity> GetAll();

        void Add(Tentity Entity);
        void AddRange(IEnumerable<Tentity> Entities);

        void Remove(Tentity Entity);
        void RemoveRange(IEnumerable<Tentity> Entities);

        Tentity SingleOrDefault( Expression<Func<Tentity, bool>> Predicate );
        IEnumerable<Tentity> Find( Expression<Func<Tentity, bool>> Predicate );
    }
}