using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Extensions.Interfaces;
using NetByForms.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetByForms.Infrastructure.Repository
{
    public class FormInputRepositoryRead : RepositoryRead<FormInput>, IFormInputRepositoryRead
    {
        public FormInputRepositoryRead(ApplicationDbContext context) : base(context)
        {
        }
    }
}
