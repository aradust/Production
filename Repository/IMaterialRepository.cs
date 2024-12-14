using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с материалами.
    /// Определяет методы для получения, добавления, обновления и удаления материалов.
    /// </summary>
    internal interface IMaterialRepository
    {
        /// <summary>
        /// Получает все материалы.
        /// </summary>
        /// <returns>Коллекция всех материалов.</returns>
        IEnumerable<Material> GetAll();

        /// <summary>
        /// Получает материал по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор материала.</param>
        /// <returns>Материал с указанным идентификатором, или <c>null</c>, если материал не найден.</returns>
        Material GetByID(int id);

        /// <summary>
        /// Добавляет новый материал в хранилище.
        /// </summary>
        /// <param name="material">Материал, который необходимо добавить.</param>
        /// <returns>Добавленный материал с обновленными данными (например, с присвоенным ID).</returns>
        Material Add(Material material);

        /// <summary>
        /// Обновляет существующий материал.
        /// </summary>
        /// <param name="material">Материал с обновленными данными.</param>
        /// <returns>Обновленный материал.</returns>
        Material Update(Material material);

        /// <summary>
        /// Удаляет материал из хранилища.
        /// </summary>
        /// <param name="material">Материал, который необходимо удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного материала, или <c>0</c>, если удаление не удалось.</returns>
        ulong Delete(int Id);
    }
}
