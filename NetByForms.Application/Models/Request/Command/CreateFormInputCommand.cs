using MediatR;
using NetByForms.Application.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetByForms.Application.Models.Request.Command
{
    public class CreateFormInputCommand : IRequest<Guid>
    {
        [Required]
        public Guid FormId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        public string InputType { get; set; } = "text";
        public bool IsRequired { get; set; }
        public List<FormInputOptionDto> Options { get; set; } = new List<FormInputOptionDto>();
    }
}
