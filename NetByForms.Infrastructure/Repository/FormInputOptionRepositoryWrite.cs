using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions;
using NetByForms.Infrastructure.Repository.Extensions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetByForms.Infrastructure.Repository.Interfaces
{
    public class FormInputOptionRepositoryWrite : RepositoryWrite<FormInputOption>, IFormInputOptionRepositoryWrite
    {
        public FormInputOptionRepositoryWrite(ApplicationDbContext context) : base(context)
        {
        }
    }
}
