using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetByForms.Infrastructure.Repository
{
    internal class FormInputRepositoryWrite : RepositoryWrite<FormInput>, IFormInputRepositoryWrite
    {
        public FormInputRepositoryWrite(ApplicationDbContext context) : base(context)
        {
        }
    }
}
