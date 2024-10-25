using AutoMapper;
using MediatR;
using NetByForms.Application.Models.Dto;
using NetByForms.Application.Models.Request.Query;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Application.QueryHandler;

public class GetAllFormQuerHandler : IRequestHandler<GetAllFormQuery, IEnumerable<FormDto>>
{
    private readonly IFormRepositoryRead _queryRepository;
    private readonly IMapper _mapper;

    public GetAllFormQuerHandler(IFormRepositoryRead queryRepository, IMapper mapper)
    {
        _queryRepository = queryRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<FormDto>> Handle(GetAllFormQuery request, CancellationToken cancellationToken)
    {
        return await _queryRepository.GetAllProyectToAsync<FormDto>(_mapper);
    }
}