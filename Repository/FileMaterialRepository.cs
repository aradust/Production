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
    public class FileMaterialRepository : IMaterialRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о продуктах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Коллекция продуктов, загруженных из файла.
        /// </summary>
        private List<Material> _materials;

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
        public Material Add(Material material)
        {
            material.Id = _materials.Any() ? _materials.Max(p => p.Id) + 1 : 1; // Генерация уникального ID
            material.Description = "dwd";// Присваиваем текущую дату производства
            // Примерная стоимость, можно настроить

            _materials.Add(material);
            SaveToFile(); // Сохраняем изменения в файл

            return material;
        }

        /// <summary>
        /// Удаляет продукт из репозитория по объекту.
        /// </summary>
        /// <param name="material">Продукт для удаления.</param>
        /// <returns>ID удаленного продукта.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если продукт с указанным ID не найден.</exception>
        public ulong Delete(Material material)
        {
            var existingMaterial = _materials.FirstOrDefault(p => p.Id == material.Id);

            if (existingMaterial != null)
            {
                _materials.Remove(existingMaterial);
                SaveToFile(); // Сохраняем изменения в файл
                return (ulong)existingMaterial.Id;
            }
            else
            {
                throw new InvalidOperationException($"Продукт с ID {material.Id} не найден.");
            }
        }

        /// <summary>
        /// Удаляет продукт из репозитория по ID.
        /// </summary>
        /// <param name="id">Идентификатор продукта для удаления.</param>
        /// <returns>ID удаленного продукта.</returns>
        public ulong Delete(int id)
        {
            var materialToRemove = _materials.FirstOrDefault(p => p.Id == id);
            if (materialToRemove != null)
            {
                _materials.Remove(materialToRemove);
                SaveToFile(); // Сохраняем изменения в файл
            }
            if (materialToRemove == null)
            {
                return 0; // Продукт не найден
            }
            return (ulong)id;
        }

        /// <summary>
        /// Возвращает все продукты из репозитория.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        public IEnumerable<Material> GetAll()
        {
            return ReadFromFile();
        }

        /// <summary>
        /// Получает продукт по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным ID или null, если продукт не найден.</returns>
        public Material GetByID(int id)
        {
            return ReadFromFile().FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Обновляет информацию о существующем продукте в репозитории.
        /// </summary>
        /// <param name="material">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт или null, если продукт не найден.</returns>
        public Material Update(Material material)
        {
            var materials = ReadFromFile().ToList();
            var existingMaterial = materials.FirstOrDefault(p => p.Id == material.Id);
            if (existingMaterial != null)
            {
                materials.Remove(existingMaterial);
                materials.Add(material);
                WriteToFile(materials); // Сохраняем обновленную коллекцию в файл
            }
            return existingMaterial;
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

        /// <summary>
        /// Записывает обновленную коллекцию продуктов в файл.
        /// </summary>
        /// <param name="materials">Обновленная коллекция продуктов.</param>
        private void WriteToFile(IEnumerable<Material> materials)
        {
            var json = JsonConvert.SerializeObject(materials, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
