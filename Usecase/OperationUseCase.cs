using System;
using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с продуктами.
    /// Использует репозиторий <see cref="IProductRepository"/> для выполнения операций с продуктами.
    /// </summary>
    public class OperationUsecase
    {
        private readonly IOperationRepository _operationRepository;

        /// <summary>
        /// Конструктор класса <see cref="ProductionUsecase"/>.
        /// </summary>
        /// <param name="productRepository">Репозиторий для работы с продуктами.</param>
        public OperationUsecase(IOperationRepository operationRepository)
        {
            _operationRepository = operationRepository ?? throw new ArgumentNullException(nameof(operationRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Список всех продуктов.</returns>
        public IEnumerable<Operation> GetAllOperations()
        {
            return _operationRepository.GetAll();
        }

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        public Operation GetOperationById(int id)
        {
            return _operationRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными.</returns>
        public Operation AddOperation(Operation operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation), "Продукт не может быть null.");
            }

            return _operationRepository.Add(operation);
        }

        /// <summary>
        /// Обновляет данные существующего продукта.
        /// </summary>
        /// <param name="product">Обновленные данные продукта.</param>
        /// <returns>Обновленный продукт.</returns>
        public Operation UpdateOperation(Operation operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation), "Продукт не может быть null.");
            }

            return _operationRepository.Update(operation);
        }

        /// <summary>
        /// Удаляет продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта или <c>0</c>, если удаление не удалось.</returns>
        public ulong DeleteOperation(int Id)
        {
            /* if (Id == null)
             {
                 //throw new ArgumentNullException(nameof(Product product.Id), "Продукт не может быть null.");
             }*/

            return _operationRepository.Delete(Id);
        }
    }
}
