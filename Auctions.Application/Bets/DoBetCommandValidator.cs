using Auctions.Application.Mediators;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application.Bets
{
    public class DoBetCommandValidator : IValidator<DoBetCommand>
    {
        public Result Validate(DoBetCommand? request)
        {
            if (request?.LotId == Guid.Empty)
                return Result.Fail("Передан некорректный формат данных");

            return Result.Ok();
        }
    }
}
