using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Config
{
    public class BuildingConfig : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.ToTable("Building");
            builder.HasKey(b => b.Id);
            builder.HasIndex(b => b.Code)
                .HasFilter("isDeleted = 'false'");

            builder.Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(b => b.Code)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("code");

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("name");
        }
    }
}
