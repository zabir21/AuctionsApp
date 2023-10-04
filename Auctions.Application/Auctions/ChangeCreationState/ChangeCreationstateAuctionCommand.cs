using FluentResults;
using MediatR;
using System.Text.Json.Serialization;

namespace Auctions.Application.Auctions.ChangeCreationState
{
    /// <summary>
    /// Команда для отмены аукциона
    /// </summary>
    public record ChangeAuctionCreationCommand : IRequest<Result>
    {
        /// <summary>
        /// Идентификатор аукциона
        /// </summary>
        [JsonPropertyName("auctionId")]
        public Guid AuctionId { get; init; }
    }
}
