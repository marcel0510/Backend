using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Config
{
    public class ClassroomConfig : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.ToTable("Classroom");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => new { c.Code, c.Floor })
                .HasFilter("isDeleted = 'false'");

            builder.Property(c => c.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(c => c.Code)
                .IsRequired()
                .HasMaxLength(7)
                .HasColumnName ("code");

            builder.Property(c => c.IsLab)
                .IsRequired()
                .HasColumnName("isLab");

            builder.Property(c => c.Name)
                .HasMaxLength(60)
                .HasColumnName ("name");

            builder.Property(c => c.Floor)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("floor");

            builder.Property(c => c.BuildingId)
                .IsRequired()
                .HasColumnName("buildingId");

        }
    }
}
