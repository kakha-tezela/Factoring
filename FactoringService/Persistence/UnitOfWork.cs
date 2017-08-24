using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FactoringService.Persistence;
using FactoringService.Core;
using FactoringService.Core.Repositories;
using FactoringService.Persistence.Repositories;

namespace FactoringService.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private FactoringContext _context;

        public UnitOfWork(FactoringContext context)
        {
            _context = context;
            CompanyRespository = new CompanyRepository(_context);
            RepresentivePeopleRepository = new RepresentivePeopleRepository(_context);
            BussinessTypeRepository = new BussinessTypeRepository(_context);
            CountryRepository = new CountryRepository(_context);
            SocialStatusRepository = new SocialStatusRepository(_context);
            PersonStatusRepository = new PersonStatusRepository(_context);
            DocumentTypeRepository = new DocumentTypeRepository(_context);
        }

        public ICompanyRepository CompanyRespository { get; set; }
        public IRepresentivePersonRepository RepresentivePeopleRepository { get; set; }
        public IBussinessTypeRepository BussinessTypeRepository { get; set; }
        public ICountryRepository CountryRepository { get; set; }
        public ISocialStatusRepository SocialStatusRepository { get; set; }
        public IPersonStatusRepository PersonStatusRepository { get; set; }
        public IDocumentTypeRepository DocumentTypeRepository { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}