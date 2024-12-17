using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с нарядами.
    /// Определяет методы для получения, добавления, обновления и удаления нарядов.
    /// </summary>
    public interface IWorkOrderRepository
    {
        /// <summary>
        /// Получает все наряды.
        /// </summary>
        /// <returns>Коллекция всех нарядов.</returns>
        IEnumerable<WorkOrder> GetAll();

        /// <summary>
        /// Получает наряд по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор наряда.</param>
        /// <returns>Наряд с указанным идентификатором, или <c>null</c>, если наряд не найден.</returns>
        WorkOrder GetByID(int id);

        /// <summary>
        /// Добавляет новый наряд в хранилище.
        /// </summary>
        /// <param name="workOrder">Наряд, который необходимо добавить.</param>
        /// <returns>Добавленный наряд с обновленными данными (например, с присвоенным ID).</returns>
        WorkOrder Add(WorkOrder workOrder);

        /// <summary>
        /// Обновляет существующий наряд.
        /// </summary>
        /// <param name="workOrder">Наряд с обновленными данными.</param>
        /// <returns>Обновленный наряд.</returns>
        WorkOrder Update(WorkOrder workOrder);

        /// <summary>
        /// Удаляет наряд из хранилища.
        /// </summary>
        /// <param name="Id">Идентификатор наряда для удаления.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного наряда, или <c>0</c>, если удаление не удалось.</returns>
        ulong Delete(int Id);
    }
}
