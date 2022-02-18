using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSI_340_ChenRoblesWu_Website.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSI_340_ChenRoblesWu_Website.Areas.Identity.Data
{
    public class ApplicationUserDemoDataContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationUserDemoDataContext(DbContextOptions<ApplicationUserDemoDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder) 
        {
            builder.Property(u => u.FirstName).HasMaxLength(255);
            builder.Property(u => u.LastName).HasMaxLength(255);
        }
    }
}
