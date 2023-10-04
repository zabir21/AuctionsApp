using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Auctions.Application.Auctions.Delete
{
    /// <summary>
    /// Команда для удаления ауцкиона
    /// </summary>
    public record DeleteAuctionCommand : IRequest<Result>
    {
        /// <summary>
        /// Идентификатор аукциона
        /// </summary>
        [JsonPropertyName("auctionId")]
        public Guid AuctionId { get; init; }
    }
}
