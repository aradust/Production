using System;
using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с продуктами.
    /// Использует репозиторий <see cref="IProductRepository"/> для выполнения операций с продуктами.
    /// </summary>
    internal class WorkShopUsecase
    {
        private readonly IWorkShopRepository _workShopRepository;

        /// <summary>
        /// Конструктор класса <see cref="ProductionUsecase"/>.
        /// </summary>
        /// <param name="productRepository">Репозиторий для работы с продуктами.</param>
        public WorkShopUsecase(IWorkShopRepository workShopRepository)
        {
            _workShopRepository = workShopRepository ?? throw new ArgumentNullException(nameof(workShopRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Список всех продуктов.</returns>
        public IEnumerable<WorkShop> GetAllWorkShop()
        {
            return _workShopRepository.GetAll();
        }

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        public WorkShop GetWorkShopById(int id)
        {
            return _workShopRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными.</returns>
        public WorkShop AddWorkShop(WorkShop workShop)
        {
            if (workShop == null)
            {
                throw new ArgumentNullException(nameof(workShop), "Продукт не может быть null.");
            }

            return _workShopRepository.Add(workShop);
        }

        /// <summary>
        /// Обновляет данные существующего продукта.
        /// </summary>
        /// <param name="product">Обновленные данные продукта.</param>
        /// <returns>Обновленный продукт.</returns>
        public WorkShop UpdateWorkShop(WorkShop workShop)
        {
            if (workShop == null)
            {
                throw new ArgumentNullException(nameof(workShop), "Продукт не может быть null.");
            }

            return _workShopRepository.Update(workShop);
        }

        /// <summary>
        /// Удаляет продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта или <c>0</c>, если удаление не удалось.</returns>
        public ulong DeleteWorkShop(int Id)
        {
            /* if (Id == null)
             {
                 //throw new ArgumentNullException(nameof(Product product.Id), "Продукт не может быть null.");
             }*/

            return _workShopRepository.Delete(Id);
        }
    }
}
