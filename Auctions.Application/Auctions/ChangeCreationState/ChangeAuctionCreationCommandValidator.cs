﻿using Auctions.Application.Mediators;
using FluentResults;

namespace Auctions.Application.Auctions.ChangeCreationState
{
    /// <inheritdoc />
    public class ChangeAuctionCreationCommandValidator : IValidator<ChangeAuctionCreationCommand>
    {
        /// <inheritdoc />
        public Result Validate(ChangeAuctionCreationCommand? request)
        {
            if (request is null)
                return Result.Fail("Не удалось распознать данные");

            if (request.AuctionId == Guid.Empty)
                return Result.Fail("Передан некорректный идентификатор");

            return Result.Ok();
        }
    }
}
