using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using FactoringService.Core.Domain;
using FactoringService.Persistence.EntityConfigurations;

namespace FactoringService.Persistence
{
    public class FactoringContext : DbContext
    {
        public FactoringContext() : base("name = FactoryConn")
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<BussinessType> BussinessTypes { get; set; }
        public DbSet<BussinessTypeTranslate> BussinessTypeTranslates { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryTranslate> CountryTranslates { get; set; }
        public DbSet<RepresentivePerson> RepresentivePeople { get; set; }
        public DbSet<SocialStatus> SocialStatuses { get; set; }
        public DbSet<SocialStatusTranslate> SocialStatusTranslates { get; set; }
        public DbSet<PersonStatus> PersonStatuses { get; set; }
        public DbSet<PersonStatusTranslate> PersonStatusTranslates { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<DocumentTypeTranslate> DocumentTypeTranslates { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CompanyConfigurations());
            modelBuilder.Configurations.Add(new CountryTranslateConfigurations());
            modelBuilder.Configurations.Add(new BussinessTypeTranslateConfigurations());
            modelBuilder.Configurations.Add(new DocumentTypeTranslateConfigurations());
            modelBuilder.Configurations.Add(new PersonStatusTranslateConfigurations());
            modelBuilder.Configurations.Add(new SocialStatusTranslateConfigurations());
            modelBuilder.Configurations.Add(new RepresentivePeopleConfigurations());
        }
    }
}