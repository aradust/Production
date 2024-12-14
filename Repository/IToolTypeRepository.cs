using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    /// <summary>
    /// Интерфейс репозитория для работы с типами инструментов.
    /// Определяет методы для получения, добавления, обновления и удаления типов инструментов.
    /// </summary>
    public interface IToolTypeRepository
    {
        /// <summary>
        /// Получает все типы инструментов.
        /// </summary>
        /// <returns>Список всех типов инструментов.</returns>
        IList<ToolType> GetAll();

        /// <summary>
        /// Получает тип инструмента по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор типа инструмента.</param>
        /// <returns>Тип инструмента с указанным идентификатором, или <c>null</c>, если тип не найден.</returns>
        ToolType GetById(int id);

        /// <summary>
        /// Добавляет новый тип инструмента в хранилище.
        /// </summary>
        /// <param name="toolType">Тип инструмента, который необходимо добавить.</param>
        /// <returns>Добавленный тип инструмента с обновленными данными (например, с присвоенным ID).</returns>
        ToolType Add(ToolType toolType);

        /// <summary>
        /// Обновляет существующий тип инструмента.
        /// </summary>
        /// <param name="toolType">Тип инструмента с обновленными данными.</param>
        /// <returns>Обновленный тип инструмента.</returns>
        ToolType Update(ToolType toolType);

        /// <summary>
        /// Удаляет тип инструмента из хранилища.
        /// </summary>
        /// <param name="id">Идентификатор типа инструмента для удаления.</param>
        /// <returns>ID удаленного типа инструмента, или <c>0</c>, если удаление не удалось.</returns>
        int Delete(int id);
    }
}
