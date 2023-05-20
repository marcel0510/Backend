using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("User");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email)
                .IsUnique()
                .HasFilter("isDeleted = 'false'");
            builder.HasQueryFilter(u => !u.IsDeleted);

            builder.Property(u => u.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("email");

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("password");

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("name");

            builder.Property(u => u.Role)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(10)
                .HasColumnName("role");

            builder.Property(u => u.IsDeleted)
                .HasDefaultValue(false);
            builder.Property(u => u.CreatedBy)
                .HasDefaultValue(1);
            builder.Property(u => u.CreatedDate)
                .HasDefaultValue(DateTime.Now);


        }
    }
}
