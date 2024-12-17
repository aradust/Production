using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления объектами <see cref="Tools"/>, с сохранением данных в JSON-файл.
    /// </summary>
    public class FileToolsRepository : InMemoryToolsRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileToolsRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных.</param>
        public FileToolsRepository(string filePath)
        {
            _filePath = filePath;

            // Загружаем данные из файла при инициализации
            _tools = LoadFromFile();
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция инструментов, загруженных из файла.</returns>
        private List<Tools> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Tools>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Tools>>(jsonString) ?? new List<Tools>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию инструментов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_tools, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Возвращает все инструменты.
        /// </summary>
        /// <returns>Коллекция всех инструментов.</returns>
        public override IEnumerable<Tools> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию инструментов.
        /// </summary>
        /// <returns>Коллекция инструментов.</returns>
        private IEnumerable<Tools> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<Tools>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Tools>>(json) ?? new List<Tools>();
        }

        /// <summary>
        /// Получает инструмент по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор инструмента.</param>
        /// <returns>Инструмент с указанным ID или null, если инструмент не найден.</returns>
        public override Tools GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующем инструменте.
        /// </summary>
        /// <param name="tool">Инструмент с обновленными данными.</param>
        /// <returns>Обновленный инструмент или null, если инструмент не найден.</returns>
        public override Tools Update(Tools tools)
        {
            var updated = base.Update(tools);
            SaveToFile();
            return updated;
        }

        /// <summary>
        /// Удаляет инструмент из репозитория.
        /// </summary>
        /// <param name="tools">Инструмент для удаления.</param>
        /// <returns>ID удаленного инструмента.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если инструмент с указанным ID не найден.</exception>
        public override ulong Delete(int id)
        {
            var deleted = base.Delete(id);
            SaveToFile();
            return deleted;
        }

        /// <summary>
        /// Добавляет новый инструмент в репозиторий и сохраняет изменения в файл.
        /// Инструменту автоматически присваивается уникальный идентификатор.
        /// </summary>
        /// <param name="tool">Инструмент для добавления.</param>
        /// <returns>Добавленный инструмент с уникальным ID.</returns>
        public override Tools Add(Tools tool)
        {
            var added = base.Add(tool);
            SaveToFile(); // Сохраняем изменения в файл
            return added;
        }
    }
}
