﻿using Auctions.Domain;
using System.Text.Json.Serialization;

namespace AuctionsApp.Controllers.Auction.Dto
{
    /// <summary>
    /// Базовое ДТО аукциона
    /// </summary>
    public record AuctionDto
    {
        /// <summary>
        /// Идентификатор аукциона
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; init; }

        /// <summary>
        /// Название ауцкиона
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// Дата начала аукциона
        /// </summary>
        [JsonPropertyName("dateStart")]
        public DateTime DateStart { get; init; }

        /// <summary>
        /// Дата завершения ауцкиона
        /// </summary>
        [JsonPropertyName("dateEnd")]
        public DateTime DateEnd { get; init; }

        /// <summary>
        /// Статус аукциона
        /// </summary>
        [JsonPropertyName("status")]
        public AuctionStatus Status { get; init; }

        // TODO Lots
        // TODO нужно ли имя и идентификатор автора
    }
}
