namespace Auctions.Domain
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User 
    {
        /// <summary>
        /// Идентификатор пользователя
        /// прочесть и инциализировать
        /// </summary>
        public int Id { get; init; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; init; }
        /// <summary>
        /// Емайл пользователя
        /// </summary>
        public string Email { get; init; }
    }
}
