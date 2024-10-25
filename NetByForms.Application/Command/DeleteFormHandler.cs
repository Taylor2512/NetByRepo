using MediatR;
using NetByForms.Application.Models.Request.Command;
using NetByForms.Infrastructure.Repository.Interfaces;

namespace NetByForms.Application.Command
{
    public class DeleteFormHandler : IRequestHandler<DeleteFormCommand, bool>
    {
        private readonly IFormRepositoryRead _queryformRepository;
        private readonly IFormRepositoryWrite _formRepository;

        public DeleteFormHandler(IFormRepositoryRead queryformRepository, IFormRepositoryWrite formRepository)
        {
            _queryformRepository = queryformRepository;
            _formRepository = formRepository;
        }

        public async Task<bool> Handle(DeleteFormCommand request, CancellationToken cancellationToken)
        {
            var form = await _queryformRepository.GetByIdAsync(request.Id);
            if (form == null)
            {
                return false;
            }

            _formRepository.Remove(form);
            await _formRepository.SaveChangesAsync();
            return true;
        }
    }
}