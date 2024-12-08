using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления продуктами с сохранением данных в JSON-файл.
    /// Реализует интерфейс <see cref="IProductRepository"/>.
    /// </summary>
    public class FileProductRepository : IProductRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о продуктах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Коллекция продуктов, загруженных из файла.
        /// </summary>
        private List<Product> _products;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileProductRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о продуктах.</param>
        public FileProductRepository(string filePath)
        {
            _filePath = filePath;
            _products = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private List<Product> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Product>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Product>>(jsonString) ?? new List<Product>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию продуктов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_products, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Добавляет новый продукт в репозиторий и сохраняет изменения в файл.
        /// Продукту автоматически присваивается уникальный идентификатор, текущая дата производства и стоимость.
        /// </summary>
        /// <param name="product">Продукт для добавления.</param>
        /// <returns>Добавленный продукт с уникальным ID, датой производства и стоимостью.</returns>
        public Product Add(Product product)
        {
            product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1; // Генерация уникального ID
            product.LastProductionDate = DateTime.Now; // Присваиваем текущую дату производства
            product.Cost = 100; // Примерная стоимость, можно настроить

            _products.Add(product);
            SaveToFile(); // Сохраняем изменения в файл

            return product;
        }

        /// <summary>
        /// Удаляет продукт из репозитория по объекту.
        /// </summary>
        /// <param name="product">Продукт для удаления.</param>
        /// <returns>ID удаленного продукта.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если продукт с указанным ID не найден.</exception>
        public ulong Delete(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct != null)
            {
                _products.Remove(existingProduct);
                SaveToFile(); // Сохраняем изменения в файл
                return (ulong)existingProduct.Id;
            }
            else
            {
                throw new InvalidOperationException($"Продукт с ID {product.Id} не найден.");
            }
        }

        /// <summary>
        /// Удаляет продукт из репозитория по ID.
        /// </summary>
        /// <param name="id">Идентификатор продукта для удаления.</param>
        /// <returns>ID удаленного продукта.</returns>
        public int Delete(int id)
        {
            var productToRemove = _products.FirstOrDefault(p => p.Id == id);
            if (productToRemove != null)
            {
                _products.Remove(productToRemove);
                SaveToFile(); // Сохраняем изменения в файл
            }
            return id;
        }

        /// <summary>
        /// Возвращает все продукты из репозитория.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        public IEnumerable<Product> GetAll()
        {
            return ReadFromFile();
        }

        /// <summary>
        /// Получает продукт по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным ID или null, если продукт не найден.</returns>
        public Product GetByID(int id)
        {
            return ReadFromFile().FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Обновляет информацию о существующем продукте в репозитории.
        /// </summary>
        /// <param name="product">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт или null, если продукт не найден.</returns>
        public Product Update(Product product)
        {
            var products = ReadFromFile().ToList();
            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                products.Remove(existingProduct);
                products.Add(product);
                WriteToFile(products); // Сохраняем обновленную коллекцию в файл
            }
            return existingProduct;
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию продуктов.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private IEnumerable<Product> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<Product>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
        }

        /// <summary>
        /// Записывает обновленную коллекцию продуктов в файл.
        /// </summary>
        /// <param name="products">Обновленная коллекция продуктов.</param>
        private void WriteToFile(IEnumerable<Product> products)
        {
            var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
