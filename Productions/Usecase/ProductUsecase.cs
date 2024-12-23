using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с продуктами.
    /// Использует репозиторий <see cref="IProductRepository"/> для выполнения операций с продуктами.
    /// </summary>
    public class ProductionUsecase
    {
        protected readonly IProductRepository _productRepository;

        /// <summary>
        /// Конструктор класса <see cref="ProductionUsecase"/>.
        /// </summary>
        /// <param name="productRepository">Репозиторий для работы с продуктами.</param>
        public ProductionUsecase(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Список всех продуктов.</returns>
        public virtual BindingList<Product> GetAllProducts()
        {
            return new BindingList<Product>(_productRepository.GetAll().ToList());
        }

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        public virtual Product GetProductById(int id)
        {
            return _productRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый продукт.
        /// </summary>
        /// <param name="product">Продукт, который нужно добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными.</returns>
        public virtual Product AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Продукт не может быть null.");
            }

            return _productRepository.Add(product);
        }

        /// <summary>
        /// Обновляет данные существующего продукта.
        /// </summary>
        /// <param name="product">Обновленные данные продукта.</param>
        /// <returns>Обновленный продукт.</returns>
        public virtual Product UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Продукт не может быть null.");
            }

            return _productRepository.Update(product);
        }

        /// <summary>
        /// Удаляет продукт.
        /// </summary>
        /// <param name="Id">Идентификатор продукта.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта или <c>0</c>, если удаление не удалось.</returns>
        public virtual ulong DeleteProduct(int Id)
        {
            return _productRepository.Delete(Id);
        }
    }
}