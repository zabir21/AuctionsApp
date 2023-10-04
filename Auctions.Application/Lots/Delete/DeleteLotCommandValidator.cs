using Auctions.Application.Mediators;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application.Lots.Delete
{
    /// <summary>
    /// Валидатор команды удаления лота
    /// </summary>
    public class DeleteLotCommandValidator : IValidator<DeleteLotCommand>
    {
        /// <inheritdoc />
        public Result Validate(DeleteLotCommand? request)
        {
            if (request?.LotId == Guid.Empty)
                return Result.Fail("Передан некорректный идентификатор лота");

            return Result.Ok();
        }
    }
}
