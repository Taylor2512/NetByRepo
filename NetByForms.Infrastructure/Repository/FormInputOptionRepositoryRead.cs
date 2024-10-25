using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Infrastructure.Repository
{
    internal class FormInputOptionRepositoryRead : RepositoryRead<FormInputOption>, IFormInputOptionRepositoryRead
    {
        public FormInputOptionRepositoryRead(ApplicationDbContext context) : base(context)
        {
        }
    }
}