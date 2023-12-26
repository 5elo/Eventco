using Application.Common.Constants;
using ECUEvents.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Domain.Enums.EnumHelper;

namespace ECUEvents.Configurations.Entities
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable(AppConstant.DataBasePrefix + "_Event");

            builder.Property(e => e.Id);
            builder.Property(e => e.price).IsRequired(false);
            builder.Property(e => e.Title)
            .IsRequired()
            .HasMaxLength((int)EnumDataTypesLength.ISD_Text255);
            builder.Property(e => e.Address)
                      .HasMaxLength((int)EnumDataTypesLength.ISD_Address)
                      .IsRequired(false);

            builder.Property(e => e.Content)
                      .IsRequired(false);

            builder.Property(e => e.Brief)
                      .IsRequired(false);



            builder.Property(e => e.CreateDate)
                          .HasDefaultValueSql("(getdate())");
            builder.Property(e => e.StartDate).HasColumnType("datetime");
            builder.Property(e => e.EndDate).HasColumnType("datetime");
        }
       
    }
    
}
