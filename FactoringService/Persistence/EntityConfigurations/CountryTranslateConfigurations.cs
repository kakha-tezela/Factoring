using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using FactoringService.Core.Domain;

namespace FactoringService.Persistence.EntityConfigurations
{
    public class CountryTranslateConfigurations : EntityTypeConfiguration<CountryTranslate>
    {
        public CountryTranslateConfigurations()
        {
            Property(c => c.Language)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}