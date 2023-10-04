using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application.Auctions.ChangeCreationState
{
    /// <summary>
    /// Обработчик команды отмены аукциона
    /// </summary>
    public class ChangeAuctionCreationCommandHandler : IRequestHandler<ChangeAuctionCreationCommand, Result>
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// .ctor
        /// </summary>
        public ChangeAuctionCreationCommandHandler(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <inheritdoc />
        public async Task<Result> Handle(ChangeAuctionCreationCommand request, CancellationToken cancellationToken)
        {
            // TODO specification
            var auction = (await _unitOfWork.Auctions.GetAsync(cancellationToken))
                .FirstOrDefault(a => a.Id == request.AuctionId);

            if (auction is null)
                return Result.Fail("Аукцион с переданным идентификатором не существует");

            var result = auction.ChangeCreationState();
            if (result.IsFailed)
                return Result.Fail(result.Errors);

            await _unitOfWork.Auctions.SaveAsync(new[] { auction }, cancellationToken);
            return Result.Ok();
        }
    }
}
