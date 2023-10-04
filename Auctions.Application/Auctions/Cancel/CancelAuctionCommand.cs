using FluentResults;
using MediatR;
using System.Text.Json.Serialization;

namespace Auctions.Application.Auctions.Cancel
{
    /// <summary>
    /// Команда для отмены ауциона
    /// </summary>
    public class CancelAuctionCommand : IRequest<Result>
    {
        /// <summary>
        /// Идентификатор аукциона
        /// </summary>
        [JsonPropertyName("auctionId")]
        public Guid AuctionId { get; init; }
    }
}
