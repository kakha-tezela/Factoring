using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using FactoringService.Core.Domain;

namespace FactoringService.Persistence.EntityConfigurations
{
    public class SocialStatusTranslateConfigurations : EntityTypeConfiguration<SocialStatusTranslate>
    {
        public SocialStatusTranslateConfigurations()
        {
            Property(s => s.Language)
                .IsRequired()
                .HasMaxLength(255);

            Property(s => s.Title)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}