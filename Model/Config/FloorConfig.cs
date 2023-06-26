using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Config
{
    public class FloorConfig : IEntityTypeConfiguration<Floor>
    {
        public void Configure(EntityTypeBuilder<Floor> builder)
        {
            builder.ToTable("Floor");
            builder.HasKey(b => b.Id);


            builder.Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(b => b.Code)
               .IsRequired()
               .HasMaxLength(3)
               .HasColumnName("code");
        }
    }
}
