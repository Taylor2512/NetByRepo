using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Infrastructure.Repository
{
    internal class FormRepositoryRead : RepositoryRead<Form>, IFormRepositoryRead
    {
        public FormRepositoryRead(ApplicationDbContext context) : base(context)
        {
        }
    }

}
