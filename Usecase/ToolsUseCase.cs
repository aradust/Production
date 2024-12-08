﻿using System;
using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с продуктами.
    /// Использует репозиторий <see cref="IProductRepository"/> для выполнения операций с продуктами.
    /// </summary>
    internal class ToolsUsecase
    {
        private readonly IToolsRepository _toolsRepository;

        /// <summary>
        /// Конструктор класса <see cref="ProductionUsecase"/>.
        /// </summary>
        /// <param name="productRepository">Репозиторий для работы с продуктами.</param>
        public ToolsUsecase(IToolsRepository toolsRepository)
        {
            _toolsRepository = toolsRepository ?? throw new ArgumentNullException(nameof(toolsRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Список всех продуктов.</returns>
        public IEnumerable<Tools> GetAllTools()
        {
            return _toolsRepository.GetAll();
        }

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        public Tools GetToolsById(int id)
        {
            return _toolsRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными.</returns>
        public Tools AddTools(Tools tools)
        {
            if (tools == null)
            {
                throw new ArgumentNullException(nameof(tools), "Продукт не может быть null.");
            }

            return _toolsRepository.Add(tools);
        }

        /// <summary>
        /// Обновляет данные существующего продукта.
        /// </summary>
        /// <param name="product">Обновленные данные продукта.</param>
        /// <returns>Обновленный продукт.</returns>
        public Tools UpdateTools(Tools tools)
        {
            if (tools == null)
            {
                throw new ArgumentNullException(nameof(tools), "Продукт не может быть null.");
            }

            return _toolsRepository.Update(tools);
        }

        /// <summary>
        /// Удаляет продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта или <c>0</c>, если удаление не удалось.</returns>
        public ulong DeleteTools(int Id)
        {
            /* if (Id == null)
             {
                 //throw new ArgumentNullException(nameof(Product product.Id), "Продукт не может быть null.");
             }*/

            return _toolsRepository.Delete(Id);
        }
    }
}
