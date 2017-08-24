using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FactoringService.Core.Domain;
using FactoringService.Core.Repositories;

namespace FactoringService.Persistence.Repositories
{
    public class DocumentTypeRepository : Repository<DocumentType>, IDocumentTypeRepository
    {
        public DocumentTypeRepository( DbContext context ) : base(context)
        {
        }
    }
}