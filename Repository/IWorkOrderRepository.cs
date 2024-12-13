using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с продуктами.
    /// Определяет методы для получения, добавления, обновления и удаления продуктов.
    /// </summary>
    public interface IWorkOrderRepository
    {
        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        IEnumerable<WorkOrder> GetAll();

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        WorkOrder GetByID(int id);

        /// <summary>
        /// Добавляет новый продукт в хранилище.
        /// </summary>
        /// <param name="product">Продукт, который необходимо добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными (например, с присвоенным ID).</returns>
        WorkOrder Add(WorkOrder workOrder);

        /// <summary>
        /// Обновляет существующий продукт.
        /// </summary>
        /// <param name="product">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт.</returns>
        WorkOrder Update(WorkOrder workOrder);

        /// <summary>
        /// Удаляет продукт из хранилища. 
        /// </summary>
        /// <param name="product">Продукт, который необходимо удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта, или <c>0</c>, если удаление не удалось.</returns>
        ulong Delete(int Id);
    }
}
