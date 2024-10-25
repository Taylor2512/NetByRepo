using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetByForms.Domain.Entities;

namespace NetByForms.Infrastructure.DataAcces.Configuration
{
    public class FormConfiguration : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            _ = builder.ToTable("Forms");
            _ = builder.HasKey(f => f.Id);

            _ = builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder.Property(f => f.CreatedAt)
                .IsRequired();

            _ = builder.HasMany(f => f.Inputs)
                .WithOne(i => i.Form)
                .HasForeignKey(i => i.FormId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}