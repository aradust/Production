﻿using System;
using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с инструментами.
    /// Использует репозиторий <see cref="IToolsRepository"/> для выполнения операций с инструментами.
    /// </summary>
    internal class ToolsUsecase
    {
        private readonly IToolsRepository _toolsRepository;

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
        /// <returns>Список всех интсрументов.</returns>
        public IEnumerable<Tools> GetAllTools()
        {
            return _toolsRepository.GetAll();
        }

        /// <summary>
        /// Получает интструмент по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор интсрумента.</param>
        /// <returns>Инструмент с указанным идентификатором, или <c>null</c>, если инструмент не найден.</returns>
        public Tools GetToolsById(int id)
        {
            return _toolsRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый интструмент.
        /// </summary>
        /// <param name="tools">Интструмент, который нужно добавить.</param>
        /// <returns>Добавленный инструмент с обновленными данными.</returns>
        public Tools AddTools(Tools tools)
        {
            if (tools == null)
            {
                throw new ArgumentNullException(nameof(tools), "Продукт не может быть null.");
            }

            return _toolsRepository.Add(tools);
        }

        /// <summary>
        /// Обновляет данные существующего инструмента.
        /// </summary>
        /// <param name="tools">Обновленные данные инструмента.</param>
        /// <returns>Обновленный инструмент.</returns>
        public Tools UpdateTools(Tools tools)
        {
            if (tools == null)
            {
                throw new ArgumentNullException(nameof(tools), "Продукт не может быть null.");
            }

            return _toolsRepository.Update(tools);
        }

        /// <summary>
        /// Удаляет инструмент.
        /// </summary>
        /// <param name="tools">Инструмент, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного инструмента или <c>0</c>, если удаление не удалось.</returns>
        public ulong DeleteProduct(Tools tools)
        {
            if (tools == null)
            {
                throw new ArgumentNullException(nameof(tools), "Продукт не может быть null.");
            }

            return _toolsRepository.Delete(tools);
        }
    }
}
