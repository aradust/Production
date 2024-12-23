﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с инструментами.
    /// Использует репозиторий <see cref="IToolsRepository"/> для выполнения операций с инструментами.
    /// </summary>
    public class ToolsUsecase
    {
        protected readonly IToolsRepository _toolsRepository;

        /// <summary>
        /// Конструктор класса <see cref="ToolsUsecase"/>.
        /// </summary>
        /// <param name="toolsRepository">Репозиторий для работы с инструментами.</param>
        public ToolsUsecase(IToolsRepository toolsRepository)
        {
            _toolsRepository = toolsRepository ?? throw new ArgumentNullException(nameof(toolsRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все инструменты.
        /// </summary>
        /// <returns>Список всех инструментов.</returns>
        public virtual BindingList<Tools> GetAllTools()
        {
            return new BindingList<Tools>(_toolsRepository.GetAll().ToList());
        }

        /// <summary>
        /// Получает инструмент по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор инструмента.</param>
        /// <returns>Инструмент с указанным идентификатором, или <c>null</c>, если инструмент не найден.</returns>
        public virtual Tools GetToolsById(int id)
        {
            return _toolsRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый инструмент.
        /// </summary>
        /// <param name="tools">Инструмент, который нужно добавить.</param>
        /// <returns>Добавленный инструмент с обновленными данными.</returns>
        public virtual Tools AddTools(Tools tools)
        {
            if (tools == null)
            {
                throw new ArgumentNullException(nameof(tools), "Инструмент не может быть null.");
            }

            return _toolsRepository.Add(tools);
        }

        /// <summary>
        /// Обновляет данные существующего инструмента.
        /// </summary>
        /// <param name="tools">Обновленные данные инструмента.</param>
        /// <returns>Обновленный инструмент.</returns>
        public virtual Tools UpdateTools(Tools tools)
        {
            if (tools == null)
            {
                throw new ArgumentNullException(nameof(tools), "Инструмент не может быть null.");
            }

            return _toolsRepository.Update(tools);
        }

        /// <summary>
        /// Удаляет инструмент.
        /// </summary>
        /// <param name="Id">Идентификатор инструмента, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного инструмента или <c>0</c>, если удаление не удалось.</returns>
        public virtual ulong DeleteTools(int Id)
        {
            return _toolsRepository.Delete(Id);
        }
    }
}