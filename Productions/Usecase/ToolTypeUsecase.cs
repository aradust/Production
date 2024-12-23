using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Production.Usecase
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с типами инструментов.
    /// Использует репозиторий <see cref="IToolTypeRepository"/> для выполнения операций с типами инструментов.
    /// </summary>
    public class ToolTypeUsecase
    {
        /// <summary>
        /// Репозиторий для работы с типами инструментов.
        /// </summary>
        protected readonly IToolTypeRepository Repository;

        /// <summary>
        /// Конструктор класса <see cref="ToolTypeUsecase"/>.
        /// </summary>
        /// <param name="repository">Репозиторий для работы с типами инструментов.</param>
        public ToolTypeUsecase(IToolTypeRepository repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает тип инструмента по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор типа инструмента.</param>
        /// <returns>Тип инструмента.</returns>
        public virtual ToolType GetById(int id)
        {
            return Repository.GetById(id);
        }

        /// <summary>
        /// Получает все типы инструментов.
        /// </summary>
        /// <returns>Список всех типов инструментов.</returns>
        public virtual BindingList<ToolType> GetAll()
        {
            return new BindingList<ToolType>(Repository.GetAll().ToList());
        }

        /// <summary>
        /// Добавляет новый тип инструмента.
        /// </summary>
        /// <param name="toolType">Тип инструмента, который нужно добавить.</param>
        /// <returns>Добавленный тип инструмента с обновленными данными.</returns>
        public virtual ToolType Add(ToolType toolType)
        {
            return Repository.Add(toolType);
        }

        /// <summary>
        /// Удаляет тип инструмента.
        /// </summary>
        /// <param name="id">Идентификатор типа инструмента, который нужно удалить.</param>
        /// <returns>Количество удаленных записей (1 или 0).</returns>
        public virtual int Delete(int id)
        {
            return Repository.Delete(id);
        }
        public ToolType Update(ToolType tooltype)
        {
            if (tooltype == null)
            {
                throw new ArgumentNullException(nameof(tooltype), "Тип инструмента не может быть null.");
            }

            return Repository.Update(tooltype);
        }
    }
}
