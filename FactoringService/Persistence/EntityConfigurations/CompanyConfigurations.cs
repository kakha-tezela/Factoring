using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FactoringService.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FactoringService.Persistence.EntityConfigurations
{
    public class CompanyConfigurations : EntityTypeConfiguration<Company> 
    {
        public CompanyConfigurations()
        {
            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(350);

            Property(c => c.CompanyCode)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.PhoneNumber)
                .IsRequired()
                .HasMaxLength(9);

            Property(c => c.RegistrationAddress)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Username)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Salt)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Email)
               .IsRequired()
               .HasMaxLength(255);
        }
    }
}