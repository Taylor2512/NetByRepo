using MediatR;
using NetByForms.Application.Models.Dto;

namespace NetByForms.Application.Models.Request.Query;

public class GetAllFormQuery : IRequest<IEnumerable<FormDto>>
{
    public string Search { get; set; }
}