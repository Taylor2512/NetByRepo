using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Infrastructure.Repository
{
    public class FormInputRepositoryRead : RepositoryRead<FormInput>, IFormInputRepositoryRead
    {
        public FormInputRepositoryRead(ApplicationDbContext context) : base(context)
        {
        }
    }
}