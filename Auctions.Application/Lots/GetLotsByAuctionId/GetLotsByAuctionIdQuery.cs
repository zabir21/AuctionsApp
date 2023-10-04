using Auctions.Domain;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Auctions.Application.Lots.GetLotsByAuctionId
{
    /// <summary>
    /// Запрос на получение лотов по идентификатору ауцкиона
    /// </summary>
    public record GetLotsByAuctionIdQuery : IRequest<Result<IEnumerable<Lot>>>
    {
        /// <summary>
        /// Идентификатор ауцкиона
        /// </summary>
        [JsonPropertyName("auctionId")]
        public Guid AuctionId { get; init; }
    }
}
