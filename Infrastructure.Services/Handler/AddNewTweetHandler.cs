using System.Threading;
using System.Threading.Tasks;
using Core.Application.Contracts.Repositories;
using Core.Domain.Entities;
using Core.Domain.Models.DTO.RequestDTO;
using MediatR;

namespace Infrastructure.Services.Handler
{
    public class AddNewTweetHandler : IRequestHandler<AddNewTweetRequestDto, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddNewTweetHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<bool> Handle(AddNewTweetRequestDto dto,
            CancellationToken cancellationToken)
        {
            await _unitOfWork.TweetRepository.AddAsync(new Tweet(dto));

            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}