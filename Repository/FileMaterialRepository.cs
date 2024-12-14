using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления материалами с сохранением данных в JSON-файл.
    /// Наследует функциональность <see cref="InMemoryMaterialRepository"/> и расширяет её поддержкой работы с файлами.
    /// </summary>
    public class FileMaterialRepository : InMemoryMaterialRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о материалах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создаёт новый экземпляр класса <see cref="FileMaterialRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о материалах.</param>
        public FileMaterialRepository(string filePath)
        {
            _filePath = filePath;
            _materials = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает материалы из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция материалов, загруженных из файла.</returns>
        private List<Material> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Material>(); // Если файл отсутствует, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Material>>(jsonString) ?? new List<Material>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию материалов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_materials, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Добавляет новый материал в репозиторий и сохраняет изменения в файл.
        /// </summary>
        /// <param name="material">Материал для добавления.</param>
        /// <returns>Добавленный материал с присвоенным уникальным идентификатором.</returns>
        public override Material Add(Material material)
        {
            var added = base.Add(material);
            SaveToFile(); // Сохраняем изменения в файл
            return added;
        }

        /// <summary>
        /// Удаляет материал из репозитория по идентификатору и сохраняет изменения в файл.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого материала.</param>
        /// <returns>Идентификатор удалённого материала.</returns>
        public override ulong Delete(int id)
        {
            var deleted = base.Delete(id);
            SaveToFile(); // Сохраняем изменения в файл
            return deleted;
        }

        /// <summary>
        /// Возвращает все материалы из репозитория.
        /// </summary>
        /// <returns>Коллекция всех материалов.</returns>
        public override IEnumerable<Material> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Получает материал по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор материала.</param>
        /// <returns>Материал с указанным идентификатором или null, если он не найден.</returns>
        public override Material GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующем материале в репозитории и сохраняет изменения в файл.
        /// </summary>
        /// <param name="material">Материал с обновлёнными данными.</param>
        /// <returns>Обновлённый материал.</returns>
        public override Material Update(Material material)
        {
            var updated = base.Update(material);
            SaveToFile(); // Сохраняем обновлённую коллекцию в файл
            return updated;
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию материалов.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция материалов, загруженных из файла.</returns>
        private IEnumerable<Material> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<Material>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Material>>(json) ?? new List<Material>();
        }
    }
}
