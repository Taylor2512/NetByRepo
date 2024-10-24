using AutoMapper;
using MediatR;
using NetByForms.Domain.Entities;
using NetByForms.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetByForms.Application.Models.Request.Command
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
