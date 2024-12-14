using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления операциями с сохранением данных в JSON-файл.
    /// Реализует интерфейс <see cref="IOperationRepository"/>.
    /// </summary>
    public class FileOperationRepository : InMemoryOperationRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные операций.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileOperationRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных операций.</param>
        public FileOperationRepository(string filePath)
        {
            _filePath = filePath;

            // Загружаем данные из файла при инициализации
            _operations = LoadFromFile();
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция операций, загруженных из файла.</returns>
        private List<Operation> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Operation>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Operation>>(jsonString) ?? new List<Operation>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию операций в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_operations, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Возвращает все операции.
        /// </summary>
        /// <returns>Коллекция всех операций.</returns>
        public override IEnumerable<Operation> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию операций.
        /// </summary>
        /// <returns>Коллекция операций.</returns>
        private IEnumerable<Operation> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<Operation>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Operation>>(json) ?? new List<Operation>();
        }

        /// <summary>
        /// Получает операцию по ее уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор операции.</param>
        /// <returns>Операция с указанным ID или null, если операция не найдена.</returns>
        public override Operation GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующей операции.
        /// </summary>
        /// <param name="operation">Операция с обновленными данными.</param>
        /// <returns>Обновленная операция или null, если операция не найдена.</returns>
        public override Operation Update(Operation operation)
        {
            var updated = base.Update(operation);
            SaveToFile();
            return updated;
        }

        /// <summary>
        /// Удаляет операцию из репозитория.
        /// </summary>
        /// <param name="operation">Операция для удаления.</param>
        /// <returns>ID удаленной операции.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если операция с указанным ID не найдена.</exception>
        public override ulong Delete(int id)
        {
            var deleted = base.Delete(id);
            SaveToFile(); // Сохраняем изменения в файл
            return (ulong)deleted;
        }

        /// <summary>
        /// Добавляет новую операцию в репозиторий и сохраняет изменения в файл.
        /// Операции автоматически присваиваются уникальные идентификаторы и другие атрибуты.
        /// </summary>
        /// <param name="operation">Операция для добавления.</param>
        /// <returns>Добавленная операция с уникальным ID и другими атрибутами.</returns>
        public override Operation Add(Operation operation)
        {
            var added = base.Add(operation);
            SaveToFile(); // Сохраняем изменения в файл
            return added;
        }
    }
}
