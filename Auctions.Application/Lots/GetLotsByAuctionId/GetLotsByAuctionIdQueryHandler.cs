using Auctions.Domain;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application.Lots.GetLotsByAuctionId
{
    /// <summary>
    /// Обработчик запроса на получение лота по идентификатору аукциона
    /// </summary>
    public class GetLotsByAuctionIdQueryHandler : IRequestHandler<GetLotsByAuctionIdQuery, Result<IEnumerable<Lot>>>
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// .ctor
        /// </summary>
        public GetLotsByAuctionIdQueryHandler(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <inheritdoc />
        public async Task<Result<IEnumerable<Lot>>> Handle(GetLotsByAuctionIdQuery request, CancellationToken cancellationToken)
        {
            var lots = await _unitOfWork.Lots
                .GetAsync(cancellationToken);

            return Result.Ok<IEnumerable<Lot>>(lots);
        }
    }
}
