using Auctions.Application.Mediators;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application.Auctions.Cancel
{
    /// <inheritdoc/>
    public class CancelAuctionCommandValidator : IValidator<CancelAuctionCommand>
    {
        public Result Validate(CancelAuctionCommand request)
        {
            if (request == null)
                return Result.Fail("Не удалось распознать данные");

            if (request.AuctionId <= Guid.Empty)
                return Result.Fail("Передан некорректный идентификатор");

            return Result.Ok();
        }
    }
}
