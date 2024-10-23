using MediatR;
using NetByForms.Application.Models.Dto;
using System.ComponentModel.DataAnnotations;

namespace NetByForms.Application.Models.Request.Command
{
    public class CreateFormCommand : IRequest<FormDto>
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        public List<FormInputDto> Inputs { get; set; } = new List<FormInputDto>();
    }

}
