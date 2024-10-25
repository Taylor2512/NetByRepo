using MediatR;

namespace NetByForms.Application.Models.Request.Command
{
    public class DeleteFormCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}