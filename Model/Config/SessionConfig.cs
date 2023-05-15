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

            builder.Property(g => g.GroupId)
                .IsRequired()
                .HasColumnName("groupId");
        }
    }
}
