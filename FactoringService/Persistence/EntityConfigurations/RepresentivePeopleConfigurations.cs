using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FactoringService.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace FactoringService.Persistence.EntityConfigurations
{
    public class RepresentivePeopleConfigurations : EntityTypeConfiguration<RepresentivePerson>
    {
        public RepresentivePeopleConfigurations()
        {
            Property(r => r.Firstname)
                .IsRequired()
                .HasMaxLength(255);

            Property(r => r.Lastname)
                .IsRequired()
                .HasMaxLength(255);

            Property(r => r.PersonalId)
                .IsRequired()
                .HasMaxLength(11);

            Property(r => r.PhysicalAddress)
                .IsRequired()
                .HasMaxLength(255);

            Property(r => r.RegistrationAddress)
               .IsRequired()
               .HasMaxLength(255);

            Property(r => r.DocumentNumber)
               .IsRequired()
               .HasMaxLength(255);

            Property(r => r.DocumentRegisteringOrganization)
               .IsRequired()
               .HasMaxLength(255);

            Property(r => r.PersonRegistrationCode)
               .HasMaxLength(255);

            Property(r => r.PersonRegisteringOrganization)
               .HasMaxLength(255);

            Property(r => r.PersonPosition)
               .HasMaxLength(255);
        }
    }
}