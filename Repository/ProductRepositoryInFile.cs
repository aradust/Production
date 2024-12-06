using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления объектами <see cref="Product"/>, с сохранением данных в JSON-файл.
    /// </summary>
    public class FileProductRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Коллекция продуктов, загруженных из файла.
        /// </summary>
        private List<Product> _products;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileProductRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных.</param>
        public FileProductRepository(string filePath)
        {
            _filePath = filePath;

            // Загружаем данные из файла при инициализации
            _products = LoadFromFile();
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
        /// Добавляет новый продукт в хранилище и сохраняет изменения в файл.
        /// Продукту автоматически присваивается уникальный идентификатор, текущая дата производства и стоимость.
        /// </summary>
        /// <param name="product">Продукт для добавления.</param>
        /// <returns>Добавленный продукт с заполненными полями идентификатора, даты производства и стоимости.</returns>
        public Product Add(Product product)
        {
            // Генерируем уникальный ID
            product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;

            // Устанавливаем текущую дату производства
            product.LastProductionDate = DateTime.Now;

            // Устанавливаем базовую стоимость
            product.Cost = 100;

            // Добавляем продукт в список
            _products.Add(product);

            // Сохраняем изменения в файл
            SaveToFile();

            return product;
        }
    }
}
