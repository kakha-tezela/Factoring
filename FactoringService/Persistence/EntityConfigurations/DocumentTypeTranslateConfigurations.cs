using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using FactoringService.Core.Domain;

namespace FactoringService.Persistence.EntityConfigurations
{
    public class DocumentTypeTranslateConfigurations : EntityTypeConfiguration<DocumentTypeTranslate>
    {
        public DocumentTypeTranslateConfigurations()
        {
            Property(d => d.Language)
                .IsRequired()
                .HasMaxLength(255);

            Property(d => d.Title)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}