using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using FactoringService.Core.Domain;

namespace FactoringService.Persistence.EntityConfigurations
{
    public class BussinessTypeTranslateConfigurations : EntityTypeConfiguration<BussinessTypeTranslate>
    {
        public BussinessTypeTranslateConfigurations()
        {
            Property(b => b.Language)
                .IsRequired()
                .HasMaxLength(255);

            Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}