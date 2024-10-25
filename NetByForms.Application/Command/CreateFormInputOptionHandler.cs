using AutoMapper;
using MediatR;
using NetByForms.Application.Models.Request.Command;
using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Application.Command
{
    public class CreateFormInputOptionHandler : IRequestHandler<CreateFormInputOptionCommand, Guid>
    {
        private readonly IFormInputOptionRepositoryWrite _formRepository;
        private readonly IMapper _mapper;

        public CreateFormInputOptionHandler(IFormInputOptionRepositoryWrite formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateFormInputOptionCommand request, CancellationToken cancellationToken)
        {
            var formInputOption = _mapper.Map<FormInputOption>(request);
            _formRepository.Add(formInputOption);
            await _formRepository.SaveChangesAsync();
            return formInputOption.Id;
        }
    }
}