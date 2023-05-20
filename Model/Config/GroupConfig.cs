using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Config
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Group");
            builder.HasKey(g => g.Id);
            builder.HasQueryFilter(g => !g.IsDeleted);

            builder.Property(g => g.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(6)
                .HasColumnName("name");

            builder.Property(g => g.SubjectId)
                .IsRequired()
                .HasColumnName("subjectId");

            builder.Property(g => g.ClassroomId)
                .IsRequired()
                .HasColumnName("classroomId");
            builder.Property(c => c.IsDeleted)
                .HasDefaultValue(false);
            builder.Property(g => g.CreatedBy)
                .HasDefaultValue(1);
            builder.Property(g => g.CreatedDate)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
