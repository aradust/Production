using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с продуктами.
    /// Определяет методы для получения, добавления, обновления и удаления продуктов.
    /// </summary>
    internal interface IToolsRepository
    {
        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        IEnumerable<Tools> GetAll();

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        Tools GetByID(int id);

        /// <summary>
        /// Добавляет новый продукт в хранилище.
        /// </summary>
        /// <param name="product">Продукт, который необходимо добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными (например, с присвоенным ID).</returns>
        Tools Add(Tools tools);

        /// <summary>
        /// Обновляет существующий продукт.
        /// </summary>
        /// <param name="product">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт.</returns>
        Tools Update(Tools tools);

        /// <summary>
        /// Удаляет продукт из хранилища.
        /// </summary>
        /// <param name="product">Продукт, который необходимо удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта, или <c>0</c>, если удаление не удалось.</returns>
        ulong Delete(Tools tools);
    }
}
