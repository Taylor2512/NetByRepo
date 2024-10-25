using MediatR;
using System.ComponentModel.DataAnnotations;

namespace NetByForms.Application.Models.Request.Command
{
    public class CreateFormInputOptionCommand : FormInputOptionRequest, IRequest<Guid>
    {
        [Required]
        public Guid FormInputId { get; set; }
    }

    public class FormInputOptionRequest
    {
        [Required]
        public string OptionValue { get; set; } = string.Empty;

        [Required]
        public string DisplayText { get; set; } = string.Empty;
    }
}