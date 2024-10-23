using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetByForms.Application.Models.Request.Command
{
    public class DeleteFormCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

}
