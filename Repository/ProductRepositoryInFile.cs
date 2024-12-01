using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Production
{
    internal class FileProductRepository : IProductRepository
    {
        private readonly string _filePath = "products.json";
        private List<Product> _products;

        public FileProductRepository(string filePath)
        {
            _filePath = filePath;
            _products = LoadFromFile();
        }

        // Метод для загрузки данных из файла с использованием Newtonsoft.Json
        private List<Product> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Product>(); // Возвращаем пустой список, если файл не существует
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Product>>(jsonString) ?? new List<Product>();
        }

        // Метод для сохранения данных в файл с использованием Newtonsoft.Json
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_products, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetByID(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product product)
        {
            // Присваиваем новый ID, если он не был указан
            if (product.Id == 0)
            {
                product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
            }

            _products.Add(product);
            SaveToFile();
            return product;
        }

        public Product Update(Product product)
        {
            var existingProduct = GetByID(product.Id);
            if (existingProduct == null)
            {
                throw new InvalidOperationException($"Product with ID {product.Id} not found.");
            }

            Delete(existingProduct);
            Add(product);

            SaveToFile();
            return existingProduct;
        }

        public ulong Delete(Product product)
        {
            var existingProduct = GetByID(product.Id);
            if (existingProduct == null)
            {
                return 0; // Продукт не найден
            }

            _products.Remove(existingProduct);
            SaveToFile();
            return (ulong)product.Id;
        }
    }
}
