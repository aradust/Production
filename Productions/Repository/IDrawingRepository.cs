using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с чертежами.
    /// Определяет методы для получения, добавления, обновления и удаления чертежей.
    /// </summary>
    public interface IDrawingRepository
    {
        /// <summary>
        /// Получает все чертежи.
        /// </summary>
        /// <returns>Коллекция всех чертежей.</returns>
        IEnumerable<Drawing> GetAll();

        /// <summary>
        /// Получает чертеж по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор чертежа.</param>
        /// <returns>Чертеж с указанным идентификатором, или <c>null</c>, если чертеж не найден.</returns>
        Drawing GetByID(int id);

        /// <summary>
        /// Добавляет новый чертеж в хранилище.
        /// </summary>
        /// <param name="drawing">Чертеж, который необходимо добавить.</param>
        /// <returns>Добавленный чертеж с обновленными данными (например, с присвоенным ID).</returns>
        Drawing Add(Drawing drawing);

        /// <summary>
        /// Обновляет существующий чертеж.
        /// </summary>
        /// <param name="drawing">Чертеж с обновленными данными.</param>
        /// <returns>Обновленный чертеж.</returns>
        Drawing Update(Drawing drawing);

        /// <summary>
        /// Удаляет чертеж из хранилища.
        /// </summary>
        /// <param name="Id">Идентификатор чертежа, который необходимо удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного чертежа, или <c>0</c>, если удаление не удалось.</returns>
        ulong Delete(int Id);
    }
}
