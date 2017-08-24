using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FactoringService.Core.Repositories;

namespace FactoringService.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository CompanyRespository { get; }
        IRepresentivePersonRepository RepresentivePeopleRepository { get; }
        IBussinessTypeRepository BussinessTypeRepository { get; }
        ICountryRepository CountryRepository { get; }
        ISocialStatusRepository SocialStatusRepository { get; }
        IPersonStatusRepository PersonStatusRepository { get; }
        IDocumentTypeRepository DocumentTypeRepository { get; }

        int Complete();
    }
}