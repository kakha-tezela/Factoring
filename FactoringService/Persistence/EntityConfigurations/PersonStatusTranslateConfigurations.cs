using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using FactoringService.Core.Domain;

namespace FactoringService.Persistence.EntityConfigurations
{
    public class PersonStatusTranslateConfigurations : EntityTypeConfiguration<PersonStatusTranslate>
    {
        public PersonStatusTranslateConfigurations()
        {
            Property(p => p.Language)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}