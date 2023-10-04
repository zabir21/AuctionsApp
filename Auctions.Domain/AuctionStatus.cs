namespace Auctions.Domain
{
    /// <summary>
    /// Статус аукциона
    /// </summary>
    public enum AuctionStatus
    {
        /// <summary>
        /// Неизвестный статус
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Этап создания аукционов
        /// </summary>
        Creation = 1,

        /// <summary>
        /// Этап ожидания торгов
        /// </summary>
        WaitBidding = 2,

        /// <summary>
        /// Этап торгов
        /// </summary>
        Bidding = 3,

        /// <summary>
        /// Аукцион завершен
        /// </summary>
        Complete = 4,

        /// <summary>
        /// Аукцион отменен
        /// </summary>
        Canceled = 5,
    }
}
