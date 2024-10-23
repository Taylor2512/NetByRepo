using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Infrastructure.Repository
{
    internal class FormRepositoryWrite : RepositoryWrite<Form>, IFormRepositoryWrite
    {
        public FormRepositoryWrite(ApplicationDbContext context) : base(context)
        {
        }
    }
}
