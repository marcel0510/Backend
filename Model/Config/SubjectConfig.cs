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


            builder.Property(s => s.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            builder.Property(s => s.Code)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnName("code");

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(90)
                .HasColumnName("name");

            builder.Property(s => s.NumHours)
                .IsRequired();

            builder.Property(s => s.NumCredits)
                .IsRequired();

            builder.Property(s => s.NumSemester)
                .IsRequired();

            builder.Property(s => s.IsLab)
                .IsRequired();
        }
    }
}
