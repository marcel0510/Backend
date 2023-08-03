using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Config
{
    public class SubjectConfig : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subject");
            builder.HasKey(s => s.Id);
            builder.HasIndex(s => s.Code)
                .IsUnique()
                .HasFilter("isDeleted = 'false'");
            builder.HasQueryFilter(s => !s.IsDeleted);


            builder.Property(s => s.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            builder.Property(s => s.Code)
                .IsRequired()
                .HasMaxLength(12)
                .HasColumnName("code");

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(90)
                .HasColumnName("name");

            builder.Property(s => s.Alias)
                .HasColumnName("alias")
                .HasMaxLength(50);

            builder.Property(s => s.NumHours)
                .IsRequired();

            builder.Property(s => s.NumCredits)
                .IsRequired();

            builder.Property(s => s.NumSemester)
                .IsRequired();

            builder.Property(s => s.IsLab)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(s => s.IsDeleted)
                .HasDefaultValue(false);
            builder.Property(s => s.CreatedBy)
                .HasDefaultValue(1);
            builder.Property(s => s.CreatedDate)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
