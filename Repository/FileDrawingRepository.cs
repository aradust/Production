using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления продуктами с сохранением данных в JSON-файл.
    /// Реализует интерфейс <see cref="IDrawingRepository"/>.
    /// </summary>
    public class FileDrawingRepository : IDrawingRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о продуктах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Коллекция продуктов, загруженных из файла.
        /// </summary>
        private List<Drawing> _drawings;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileDrawingRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о продуктах.</param>
        public FileDrawingRepository(string filePath)
        {
            _filePath = filePath;
            _drawings = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private List<Drawing> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Drawing>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Drawing>>(jsonString) ?? new List<Drawing>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию продуктов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_drawings, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Добавляет новый продукт в репозиторий и сохраняет изменения в файл.
        /// Продукту автоматически присваивается уникальный идентификатор, текущая дата производства и стоимость.
        /// </summary>
        /// <param name="product">Продукт для добавления.</param>
        /// <returns>Добавленный продукт с уникальным ID, датой производства и стоимостью.</returns>
        public Drawing Add(Drawing product)
        {
            product.Id = _drawings.Any() ? _drawings.Max(p => p.Id) + 1 : 1; // Генерация уникального ID 
            // Примерная стоимость, можно настроить

            _drawings.Add(product);
            SaveToFile(); // Сохраняем изменения в файл

            return product;
        }

        public ulong Delete(int id)
        {
            var productToRemove = _drawings.FirstOrDefault(p => p.Id == id);
            if (productToRemove != null)
            {
                _drawings.Remove(productToRemove);
                SaveToFile(); // Сохраняем изменения в файл
            }
            if (productToRemove == null)
            {
                return 0; // Продукт не найден
            }
            return (ulong)id;
        }

        /// <summary>
        /// Возвращает все продукты из репозитория.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        public IEnumerable<Drawing> GetAll()
        {
            return ReadFromFile();
        }

        /// <summary>
        /// Получает продукт по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным ID или null, если продукт не найден.</returns>
        public Drawing GetByID(int id)
        {
            return ReadFromFile().FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Обновляет информацию о существующем продукте в репозитории.
        /// </summary>
        /// <param name="product">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт или null, если продукт не найден.</returns>
        public Drawing Update(Drawing product)
        {
            var drawings = ReadFromFile().ToList();
            var existingDrawing = drawings.FirstOrDefault(p => p.Id == product.Id);
            if (existingDrawing != null)
            {
                drawings.Remove(existingDrawing);
                drawings.Add(product);
                WriteToFile(drawings); // Сохраняем обновленную коллекцию в файл
            }
            return existingDrawing;
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию продуктов.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private IEnumerable<Drawing> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<Drawing>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Drawing>>(json) ?? new List<Drawing>();
        }

        /// <summary>
        /// Записывает обновленную коллекцию продуктов в файл.
        /// </summary>
        /// <param name="drawings">Обновленная коллекция продуктов.</param>
        private void WriteToFile(IEnumerable<Drawing> drawings)
        {
            var json = JsonConvert.SerializeObject(drawings, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
