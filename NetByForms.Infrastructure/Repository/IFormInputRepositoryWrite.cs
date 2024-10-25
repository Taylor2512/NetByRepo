using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Infrastructure.Repository
{
    internal class FormInputRepositoryWrite : RepositoryWrite<FormInput>, IFormInputRepositoryWrite
    {
        public FormInputRepositoryWrite(ApplicationDbContext context) : base(context)
        {
        }
    }
}