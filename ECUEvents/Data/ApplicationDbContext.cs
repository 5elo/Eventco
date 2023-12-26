using ECUEvents.Configurations;
using ECUEvents.Configurations.Entities;
using ECUEvents.Configurations.Lookups;
using ECUEvents.Models.Entities;
using ECUEvents.Models.Lookups;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;

namespace ECUEvents.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Event>? Events { get; set; }
        public DbSet<LkpEventCategory>? EventCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EventConfiguration());
            builder.ApplyConfiguration(new LkpEventCategoryConfiguration());
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            base.OnModelCreating(builder);

        }

    }
}

