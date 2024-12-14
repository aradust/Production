using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления продуктами с сохранением данных в JSON-файл.
    /// Реализует интерфейс <see cref="IMaterialRepository"/>.
    /// </summary>
    public class FileMaterialRepository : InMemoryMaterialRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о продуктах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileMaterialRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о продуктах.</param>
        public FileMaterialRepository(string filePath)
        {
            _filePath = filePath;
            _materials = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private List<Material> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Material>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Material>>(jsonString) ?? new List<Material>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию продуктов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_materials, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Добавляет новый продукт в репозиторий и сохраняет изменения в файл.
        /// Продукту автоматически присваивается уникальный идентификатор, текущая дата производства и стоимость.
        /// </summary>
        /// <param name="material">Продукт для добавления.</param>
        /// <returns>Добавленный продукт с уникальным ID, датой производства и стоимостью.</returns>
        public override Material Add(Material material)
        {
            var added = base.Add(material);
            SaveToFile(); // Сохраняем изменения в файл

            return added;
        }

        /// <summary>
        /// Удаляет продукт из репозитория по ID.
        /// </summary>
        /// <param name="id">Идентификатор продукта для удаления.</param>
        /// <returns>ID удаленного продукта.</returns>
        public override ulong Delete(int id)
        {
            var deleted = base.Delete(id);
            SaveToFile();
            return deleted;
        }

        /// <summary>
        /// Возвращает все продукты из репозитория.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        public override IEnumerable<Material> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Получает продукт по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным ID или null, если продукт не найден.</returns>
        public override Material GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующем продукте в репозитории.
        /// </summary>
        /// <param name="material">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт или null, если продукт не найден.</returns>
        public override Material Update(Material material)
        {
            var updated = base.Update(material);
            SaveToFile();
            return updated;
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию продуктов.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private IEnumerable<Material> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<Material>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Material>>(json) ?? new List<Material>();
        }
    }
}
