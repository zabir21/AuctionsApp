using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Auctions.Application.Bets
{
    /// <summary>
    /// Команда, чтобы сделать ставку на лот
    /// </summary>
    public record DoBetCommand : IRequest<Result>
    {
        /// <summary>
        /// Идентификатор лота
        /// </summary>
        [JsonPropertyName("lotId")]
        public Guid LotId { get; init; }

        /// <summary>
        /// Идентификатор аукциона
        /// </summary>
        [JsonPropertyName("auctionId")]
        public Guid AuctionId { get; set; }
    }
}
