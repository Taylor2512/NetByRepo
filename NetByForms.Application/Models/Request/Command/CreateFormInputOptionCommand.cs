using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetByForms.Application.Models.Request.Command
{
    public class CreateFormInputOptionCommand : IRequest<Guid>
    {
        [Required]
        public Guid FormInputId { get; set; }

        [Required]
        public string OptionValue { get; set; } = string.Empty;

        [Required]
        public string DisplayText { get; set; } = string.Empty;
    }
}
