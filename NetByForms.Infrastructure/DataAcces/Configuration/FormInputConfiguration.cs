using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetByForms.Domain.Entities;

namespace NetByForms.Infrastructure.DataAcces.Configuration
{
    public class FormInputConfiguration : IEntityTypeConfiguration<FormInput>
    {
        public void Configure(EntityTypeBuilder<FormInput> builder)
        {
            _ = builder.ToTable("FormInputs");
            _ = builder.HasKey(i => i.Id);

            _ = builder.Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder.Property(i => i.InputType)
                .IsRequired()
                .HasMaxLength(50);

            _ = builder.HasMany(i => i.Options)
                .WithOne(o => o.FormInput)
                .HasForeignKey(o => o.FormInputId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}