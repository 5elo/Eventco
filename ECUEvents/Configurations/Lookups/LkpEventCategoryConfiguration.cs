using Application.Common.Constants;
using ECUEvents.Models.Lookups;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static Domain.Enums.EnumHelper;

namespace ECUEvents.Configurations.Lookups
{
    public class LkpEventCategoryConfiguration : IEntityTypeConfiguration<LkpEventCategory>
    {
        public void Configure(EntityTypeBuilder<LkpEventCategory> builder)
        {
            builder.ToTable(AppConstant.DataBasePrefix + "_LKP_EventCategory");



            builder.Property(e => e.CreateDate)
                      .HasColumnType("datetime")
                      .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Description).HasMaxLength((int)EnumDataTypesLength.ISD_Description);

            builder.Property(e => e.Name).IsRequired().HasMaxLength((int)EnumDataTypesLength.ISD_Name);
        }
    }
}
