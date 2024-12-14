using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с инструментами.
    /// Определяет методы для получения, добавления, обновления и удаления инструментов.
    /// </summary>
    internal interface IToolsRepository
    {
        /// <summary>
        /// Получает все инструменты.
        /// </summary>
        /// <returns>Коллекция всех инструментов.</returns>
        IEnumerable<Tools> GetAll();

        /// <summary>
        /// Получает инструмент по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор инструмента.</param>
        /// <returns>Инструмент с указанным идентификатором, или <c>null</c>, если инструмент не найден.</returns>
        Tools GetByID(int id);

        /// <summary>
        /// Добавляет новый инструмент в хранилище.
        /// </summary>
        /// <param name="tools">Инструмент, который необходимо добавить.</param>
        /// <returns>Добавленный инструмент с обновленными данными (например, с присвоенным ID).</returns>
        Tools Add(Tools tools);

        /// <summary>
        /// Обновляет существующий инструмент.
        /// </summary>
        /// <param name="tools">Инструмент с обновленными данными.</param>
        /// <returns>Обновленный инструмент.</returns>
        Tools Update(Tools tools);

        /// <summary>
        /// Удаляет инструмент из хранилища.
        /// </summary>
        /// <param name="tools">Инструмент, который необходимо удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного инструмента, или <c>0</c>, если удаление не удалось.</returns>
        ulong Delete(int Id);
    }
}
