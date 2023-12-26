using Application.Common.Constants;
using ECUEvents.Data;
using ECUEvents.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Domain.Enums.EnumHelper;

namespace ECUEvents.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
        
            builder.Property(e => e.FirstName)
                    .HasMaxLength((int)EnumDataTypesLength.ISD_Text255);

            builder.Property(e => e.LasttName)
                    .HasMaxLength((int)EnumDataTypesLength.ISD_Text255);



        }
    }
}
