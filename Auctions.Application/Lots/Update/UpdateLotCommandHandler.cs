using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application.Lots.Update
{
    /// <summary>
    /// Обработчик команды обновления лота
    /// </summary>
    public class UpdateLotCommandHandler : IRequestHandler<UpdateLotCommand, Result>
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// .ctor
        /// </summary>
        public UpdateLotCommandHandler(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <inheritdoc />
        public async Task<Result> Handle(UpdateLotCommand request, CancellationToken cancellationToken)
        {
            var auction = (await _unitOfWork.Auctions
                .GetAsync(cancellationToken))
                .FirstOrDefault(a => a.Id == request.AuctionId);

            if (auction is null)
                return Result.Fail("Нельзя обновить данный лот, т.к. для ауцкиона запрещено редактирование");

            var result = auction.UpdateLot(request.LotId, request.Name, request.Code, request.Description, request.BetStep, request.BuyoutPrice);
            if (result.IsFailed)
                return Result.Fail(result.Errors);

            await _unitOfWork.Lots.SaveAsync(new[] { result.Value }, cancellationToken);
            return Result.Ok();
        }
    }
}
