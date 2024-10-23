using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetByForms.Domain.Entities;

namespace NetByForms.Infrastructure.DataAcces.Configuration
{
    public class FormInputOptionConfiguration : IEntityTypeConfiguration<FormInputOption>
    {
        public void Configure(EntityTypeBuilder<FormInputOption> builder)
        {
            _ = builder.ToTable("FormInputOptions");
            _ = builder.HasKey(o => o.Id);

            _ = builder.Property(o => o.OptionValue)
                .IsRequired()
                .HasMaxLength(100);

            _ = builder.Property(o => o.DisplayText)
                .IsRequired()
                .HasMaxLength(100);
        }
    }

}
