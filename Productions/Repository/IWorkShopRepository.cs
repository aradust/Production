using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с цехами.
    /// Определяет методы для получения, добавления, обновления и удаления цехов.
    /// </summary>
    public interface IWorkShopRepository
    {
        /// <summary>
        /// Получает все цехи.
        /// </summary>
        /// <returns>Коллекция всех цехов.</returns>
        IEnumerable<WorkShop> GetAll();

        /// <summary>
        /// Получает цех по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор цеха.</param>
        /// <returns>Цех с указанным идентификатором, или <c>null</c>, если цех не найден.</returns>
        WorkShop GetByID(int id);

        /// <summary>
        /// Добавляет новый цех в хранилище.
        /// </summary>
        /// <param name="workShop">Цех, который необходимо добавить.</param>
        /// <returns>Добавленный цех с обновленными данными (например, с присвоенным ID).</returns>
        WorkShop Add(WorkShop workShop);

        /// <summary>
        /// Обновляет существующий цех.
        /// </summary>
        /// <param name="workShop">Цех с обновленными данными.</param>
        /// <returns>Обновленный цех.</returns>
        WorkShop Update(WorkShop workShop);

        /// <summary>
        /// Удаляет цех из хранилища.
        /// </summary>
        /// <param name="Id">Идентификатор цеха для удаления.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного цеха, или <c>0</c>, если удаление не удалось.</returns>
        ulong Delete(int Id);
    }
}
