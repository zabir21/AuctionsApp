using Auctions.Application.Mediators;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application.Lots.GetLotsByAuctionId
{
    /// <summary>
    /// Валидатор команды удаления лота
    /// </summary>
    public class GetLotsByAuctionIdQueryValidator : IValidator<GetLotsByAuctionIdQuery>
    {
        /// <inheritdoc />
        public Result Validate(GetLotsByAuctionIdQuery? request)
        {
            if (request?.AuctionId == Guid.Empty)
                return Result.Fail("Передан некорректный идентификатор ауцкиона");

            return Result.Ok();
        }
    }
}
