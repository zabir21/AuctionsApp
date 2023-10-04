using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application
{
    /// <summary>
    /// Базовая абстракция всех репозитариев
    /// </summary>
    /// <typeparam name="T">Тип объекта, с которым работает репозитарий</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Сохранение объектов
        /// </summary>
        /// <param name="objects">Объекты для сохранения</param>
        /// <param name="cancellationToken">Токен отмены операции</param>
        Task SaveAsync(IEnumerable<T> objects, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление объектов
        /// </summary>
        /// <param name="objects">Объекты для сохранения</param>
        /// <param name="cancellationToken">Токен отмены операции</param>
        Task DeleteAsync(IEnumerable<T> objects, CancellationToken cancellationToken);

        /// <summary>
        /// Обновление объектов
        /// </summary>
        /// <param name="objects">Объекты для сохранения</param>
        /// <param name="cancellationToken">Токен отмены операции</param>
        //Task UpdateAsync(IEnumerable<T> objects, CancellationToken cancellationToken);

        /// <summary>
        /// Получение элементов
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции</param>
        Task<IReadOnlyCollection<T>> GetAsync(CancellationToken cancellationToken);
    }
}
