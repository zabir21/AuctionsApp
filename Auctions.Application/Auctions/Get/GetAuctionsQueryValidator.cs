using Auctions.Application.Mediators;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application.Auctions.Get
{
    /// <inheritdoc />
    public class GetAuctionsQueryValidator : IValidator<GetAuctionsQuery>
    {
        /// <inheritdoc />
        public Result Validate(GetAuctionsQuery? request)
        {
            if (request is null)
                return Result.Fail("Не удалось распознать данные");

            if (request.LastAuctionId.HasValue && request.LastAuctionId.Value <= 0)
                return Result.Fail("Передан некорректный идентификатор последнего ауцкиона");

            return Result.Ok();
        }
    }
}
