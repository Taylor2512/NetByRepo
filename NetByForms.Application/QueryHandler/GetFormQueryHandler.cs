using AutoMapper;
using MediatR;
using NetByForms.Application.Models.Dto;
using NetByForms.Application.Models.Request.Query;
using NetByForms.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetByForms.Application.QueryHandler
{
    public class GetFormQueryHandler : IRequestHandler<GetFormQuery, FormDto?>
    {
        private readonly IFormRepositoryRead _formRepository;
        private readonly IMapper _mapper;

        public GetFormQueryHandler(IFormRepositoryRead formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _mapper = mapper;
        }

        public async Task<FormDto?> Handle(GetFormQuery request, CancellationToken cancellationToken)
        {
            var form = await _formRepository.GetByIdAsync(request.Id);

            if (form == null)
            {
                return null;
            }

            return _mapper.Map<FormDto>(form);
        }
    }
}
