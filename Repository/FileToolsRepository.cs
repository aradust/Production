using System;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления объектами <see cref="Tools"/>, с сохранением данных в JSON-файл.
    /// </summary>
    public class FileToolsRepository : IToolsRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Коллекция инструментов, загруженных из файла.
        /// </summary>
        private List<Tools> _tools;

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
        public IEnumerable<Tools> GetAll()
        {
            return ReadFromFile();
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
        public Tools GetByID(int id)
        {
            return ReadFromFile().FirstOrDefault(p => p.TypeId == id);
        }

        /// <summary>
        /// Обновляет информацию о существующем инструменте.
        /// </summary>
        /// <param name="tool">Инструмент с обновленными данными.</param>
        /// <returns>Обновленный инструмент или null, если инструмент не найден.</returns>
        public Tools Update(Tools tools)
        {
            var existingOperation = GetByID(tools.TypeId);
            if (existingOperation == null)
            {
                throw new InvalidOperationException($"Product with ID {tools.TypeId} not found.");
            }

            //Delete(existingProduct);
            Add(tools);

            return existingOperation;
        }

        /// <summary>
        /// Записывает обновленную коллекцию инструментов в файл.
        /// </summary>
        /// <param name="tools">Коллекция инструментов для записи в файл.</param>
        private void WriteToFile(IEnumerable<Tools> tools)
        {
            var json = JsonConvert.SerializeObject(tools, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Удаляет инструмент из репозитория.
        /// </summary>
        /// <param name="tools">Инструмент для удаления.</param>
        /// <returns>ID удаленного инструмента.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если инструмент с указанным ID не найден.</exception>
        public ulong Delete(int id)
        {
            var ToolsToRemove = _tools.FirstOrDefault(p => p.TypeId == id);
            if (ToolsToRemove != null)
            {
                _tools.Remove(ToolsToRemove);
                SaveToFile(); // Сохраняем изменения в файл
            }
            if (ToolsToRemove == null)
            {
                return 0; // Продукт не найден
            }
            return (ulong)id;
        }

        /// <summary>
        /// Добавляет новый инструмент в репозиторий и сохраняет изменения в файл.
        /// Инструменту автоматически присваивается уникальный идентификатор.
        /// </summary>
        /// <param name="tool">Инструмент для добавления.</param>
        /// <returns>Добавленный инструмент с уникальным ID.</returns>
        public Tools Add(Tools tool)
        {
            // Генерация уникального ID
            tool.TypeId = _tools.Any() ? _tools.Max(p => p.TypeId) + 1 : 1;

            _tools.Add(tool);
            SaveToFile(); // Сохраняем изменения в файл

            return tool;
        }
    }
}
