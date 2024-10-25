using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Infrastructure.Repository
{
    public class FormInputOptionRepositoryWrite : RepositoryWrite<FormInputOption>, IFormInputOptionRepositoryWrite
    {
        public FormInputOptionRepositoryWrite(ApplicationDbContext context) : base(context)
        {
        }
    }
}