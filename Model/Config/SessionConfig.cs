using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Config
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable("Session");
            builder.HasKey(s => s.Id);
            builder.HasQueryFilter(s => !s.IsDeleted);

            builder.Property(s => s.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(s => s.Day)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(10)
                .HasColumnName("day");

            builder.Property(s => s.StartTime)
                .IsRequired()
                .HasColumnType("time")
                .HasColumnName("startTime");

            builder.Property(s => s.EndTime)
                .IsRequired()
                .HasColumnType("time")
                .HasColumnName("endTime");

            builder.Property(s => s.GroupId)
                .IsRequired()
                .HasColumnName("groupId");

            builder.Property(s => s.IsDeleted)
                .HasDefaultValue(false);

        }
    }
}
