using Auctions.Domain;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Auctions.Application.Auctions.Get
{
    /// <summary>
    /// Запрос на получение аукционов
    /// </summary>
    public class GetAuctionsQuery : IRequest<Result<IEnumerable<Auction>>>
    {
        /// <summary>
        /// Идентификатор последнего аукциона (для пагинации)
        /// </summary>
        [JsonPropertyName("auctionId")]
        public int? LastAuctionId { get; init; }
    }
}
