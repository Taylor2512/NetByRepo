using MediatR;
using System.ComponentModel.DataAnnotations;

namespace NetByForms.Application.Models.Request.Command
{
    public record CreateFormInputCommand : ForInputRequest, IRequest<Guid>
    {
        public Guid FormId { get; set; }
    }
    public record ForInputRequest
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        public string InputType { get; set; } = "text";
        public bool IsRequired { get; set; }
        public List<FormInputOptionRequest> Options { get; set; } = new List<FormInputOptionRequest>();
    }
}