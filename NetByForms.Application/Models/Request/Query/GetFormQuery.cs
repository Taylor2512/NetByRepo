using MediatR;
using NetByForms.Application.Models.Dto;

namespace NetByForms.Application.Models.Request.Query
{
    public class GetFormQuery : IRequest<FormDto>
    {
        public Guid Id { get; set; }
    }
}
