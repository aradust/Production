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
    public class FileDrawingRepository : InMemoryDrawingRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о продуктах.
        /// </summary>
        private readonly string _filePath;

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
        public override Drawing Add(Drawing drawing)
        {
            var newDrawing = base.Add(drawing);
            SaveToFile(); // Сохраняем изменения в файл

            return newDrawing;
        }

        public override ulong Delete(int id)
        {
            var deletedId = base.Delete(id);
            SaveToFile(); // Сохраняем изменения в файл
            return (ulong)deletedId;
        }

        /// <summary>
        /// Возвращает все продукты из репозитория.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        public override IEnumerable<Drawing> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Получает продукт по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным ID или null, если продукт не найден.</returns>
        public override Drawing GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующем продукте в репозитории.
        /// </summary>
        /// <param name="product">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт или null, если продукт не найден.</returns>
        public override Drawing Update(Drawing drawing)
        {
            var updatedDrawing = base.Update(drawing);
            SaveToFile(); // Сохраняем обновленную коллекцию в файл
            return updatedDrawing;
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
    }
}
