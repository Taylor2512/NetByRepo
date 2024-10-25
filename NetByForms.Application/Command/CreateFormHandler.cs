using AutoMapper;
using MediatR;
using NetByForms.Application.Models.Dto;
using NetByForms.Application.Models.Request.Command;
using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Application.Command
{
    public class CreateFormHandler : IRequestHandler<CreateFormCommand, FormDto>
    {
        private readonly IFormRepositoryWrite _formRepository;
        private readonly IMapper _mapper;

        public CreateFormHandler(IFormRepositoryWrite formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _mapper = mapper;
        }

        public async Task<FormDto> Handle(CreateFormCommand request, CancellationToken cancellationToken)
        {
            var form = _mapper.Map<Form>(request);
            form.IsActive = true;
            _formRepository.Add(form);
            await _formRepository.SaveChangesAsync();

            return _mapper.Map<FormDto>(form);
        }
    }
}