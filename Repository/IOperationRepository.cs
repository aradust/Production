using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с операциями.
    /// Определяет методы для получения, добавления, обновления и удаления операций.
    /// </summary>
    public interface IOperationRepository
    {
        /// <summary>
        /// Получает все операции.
        /// </summary>
        /// <returns>Коллекция всех операций.</returns>
        IEnumerable<Operation> GetAll();

        /// <summary>
        /// Получает операцию по её идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор операции.</param>
        /// <returns>Операция с указанным идентификатором, или <c>null</c>, если операция не найдена.</returns>
        Operation GetByID(int id);

        /// <summary>
        /// Добавляет новую операцию в хранилище.
        /// </summary>
        /// <param name="operation">Операция, которую необходимо добавить.</param>
        /// <returns>Добавленная операция с обновленными данными (например, с присвоенным ID).</returns>
        Operation Add(Operation operation);

        /// <summary>
        /// Обновляет существующую операцию.
        /// </summary>
        /// <param name="operation">Операция с обновленными данными.</param>
        /// <returns>Обновленная операция.</returns>
        Operation Update(Operation operation);

        /// <summary>
        /// Удаляет операцию из хранилища.
        /// </summary>
        /// <param name="operation">Операция, которую необходимо удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленной операции, или <c>0</c>, если удаление не удалось.</returns>
        ulong Delete(int Id);
    }
}
