using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Auctions.Application.Lots.Delete
{
    /// <summary>
    /// Команда на удаление лота
    /// </summary>
    public record DeleteLotCommand : IRequest<Result>
    {
        /// <summary>
        /// Идентификатор аукциона
        /// </summary>
        [JsonPropertyName("auctionId")]
        public Guid AuctionId { get; init; }

        /// <summary>
        /// Идентификатор лота
        /// </summary>
        [JsonPropertyName("lotId")]
        public Guid LotId { get; init; }
    }
}
