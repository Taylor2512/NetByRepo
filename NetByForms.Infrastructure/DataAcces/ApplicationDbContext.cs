using Microsoft.EntityFrameworkCore;
using NetByForms.Domain.Entities;
using System.Reflection;

namespace NetByForms.Infrastructure.DataAcces
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<FormInput> FormInputs { get; set; }
        public DbSet<FormInputOption> FormInputOptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}