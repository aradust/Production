 using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryProductRepository : IProductRepository
    {
        protected List<Product> _products;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryProductRepository()
        {
            _products = new List<Product>();
        }

        // Получить все продукты
        virtual public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        // Получить продукт по ID
        virtual public Product GetByID(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый продукт
        virtual public Product Add(Product product)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (product.Id == 0)
            {
                product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
            }
            _products.Add(product);
            return product;
        }

        // Обновить существующий продукт
        virtual public Product Update(Product product)
        {
            var existingProduct = GetByID(product.Id);
            if (existingProduct == null)
            {
                throw new InvalidOperationException($"Product with ID {product.Id} not found.");
            }

            Delete(existingProduct.Id);
            Add(product);

            return existingProduct;
        }

        // Удалить продукт по объекту
        virtual public ulong Delete(int id) { 
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return 0; // Продукт не найден
            }

            _products.Remove(existingProduct);
            return (ulong)id;
        }
    }
}
