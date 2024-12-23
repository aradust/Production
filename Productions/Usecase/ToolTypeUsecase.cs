using System;
using System.Collections.Generic;

namespace Production.Usecase
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с типами инструментов.
    /// Использует репозиторий <see cref="IToolTypeRepository"/> для выполнения операций с типами инструментов.
    /// </summary>
    public class ToolTypeUsecase
    {
        private readonly IToolTypeRepository _repository;

        /// <summary>
        /// Конструктор класса <see cref="ToolTypeUsecase"/>.
        /// </summary>
        /// <param name="repository">Репозиторий для работы с типами инструментов.</param>
        public ToolTypeUsecase(IToolTypeRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "Репозиторий не может быть null.");
        }

        public ToolType GetById(int id)
        {
            return _repository.GetById(id);
        }
        /// <summary>
        /// Получает все типы инструментов.
        /// </summary>
        /// <returns>Список всех типов инструментов.</returns>
        public IList<ToolType> GetAll()
        {
            return _repository.GetAll();
        }

        /// <summary>
        /// Добавляет новый тип инструмента.
        /// </summary>
        /// <param name="toolType">Тип инструмента, который нужно добавить.</param>
        /// <returns>Добавленный тип инструмента с обновленными данными.</returns>
        public ToolType Add(ToolType toolType)
        {
            return _repository.Add(toolType);
        }

        /// <summary>
        /// Удаляет тип инструмента.
        /// </summary>
        /// <param name="id">Идентификатор типа инструмента, который нужно удалить.</param>
        /// <returns>Количество удаленных записей (1 или 0).</returns>
        public int Delete(int id)
        {
            return _repository.Delete(id);
        }
        public ToolType Update(ToolType tooltype)
        {
            if (tooltype == null)
            {
                throw new ArgumentNullException(nameof(tooltype), "Тип инструмента не может быть null.");
            }

            return _repository.Update(tooltype);
        }
    }
}
