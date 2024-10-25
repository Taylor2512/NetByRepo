using AutoMapper;
using MediatR;
using NetByForms.Application.Models.Request.Command;
using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Application.Command
{
    public class CreateFormInputHandler : IRequestHandler<CreateFormInputCommand, Guid>
    {
        private readonly IFormInputRepositoryWrite _formRepository;
        private readonly IMapper _mapper;

        public CreateFormInputHandler(IFormInputRepositoryWrite formRepository)
        {
            _formRepository = formRepository;
        }

        public async Task<Guid> Handle(CreateFormInputCommand request, CancellationToken cancellationToken)
        {
            var formInput = _mapper.Map<FormInput>(request);
            _formRepository.Add(formInput);
            await _formRepository.SaveChangesAsync();
            return formInput.Id;
        }
    }
}