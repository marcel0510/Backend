using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Config
{
    public class CalendarConfig : IEntityTypeConfiguration<Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            builder.ToTable("Calendar");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Period)
                .HasFilter("isDeleted = 'false'");

            builder.Property(c => c.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            builder.Property(c => c.Period)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("period");
            builder.Property(c => c.PeridoInit)
                .IsRequired()
                .HasColumnName("periodInit");

            builder.Property(C => C.PeriodEnd)
                .IsRequired()
                .HasColumnName("periodEnd");

            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false);
            builder.Property(c => c.CreatedBy)
                .HasDefaultValue(1);
            builder.Property(c => c.CreatedDate)
                .HasDefaultValue(DateTime.Now);

        }
    }
}
