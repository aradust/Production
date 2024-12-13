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
    public class FileOperationRepository : IOperationRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные операций.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Коллекция операций, загруженных из файла.
        /// </summary>
        private List<Operation> _operations;

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
        public IEnumerable<Operation> GetAll()
        {
            return ReadFromFile();
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
        public Operation GetByID(int id)
        {
            return ReadFromFile().FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Обновляет информацию о существующей операции.
        /// </summary>
        /// <param name="operation">Операция с обновленными данными.</param>
        /// <returns>Обновленная операция или null, если операция не найдена.</returns>
        public Operation Update(Operation operation)
        {
            var operations = ReadFromFile().ToList();
            var existingOperation = operations.FirstOrDefault(p => p.Id == operation.Id);
            if (existingOperation != null)
            {
                operations.Remove(existingOperation);
                operations.Add(operation);
                WriteToFile(operations);
            }
            return existingOperation;
        }

        /// <summary>
        /// Записывает обновленную коллекцию операций в файл.
        /// </summary>
        /// <param name="operations">Коллекция операций для записи в файл.</param>
        private void WriteToFile(IEnumerable<Operation> operations)
        {
            var json = JsonConvert.SerializeObject(operations, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Удаляет операцию из репозитория.
        /// </summary>
        /// <param name="operation">Операция для удаления.</param>
        /// <returns>ID удаленной операции.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если операция с указанным ID не найдена.</exception>
        public ulong Delete(int id)
        {
            var operationToRemove = _operations.FirstOrDefault(p => p.Id == id);
            if (operationToRemove != null)
            {
                _operations.Remove(operationToRemove);
                SaveToFile(); // Сохраняем изменения в файл
            }
            if (operationToRemove == null)
            {
                return 0; // Продукт не найден
            }
            return (ulong)id;
        }

        /// <summary>
        /// Добавляет новую операцию в репозиторий и сохраняет изменения в файл.
        /// Операции автоматически присваиваются уникальные идентификаторы и другие атрибуты.
        /// </summary>
        /// <param name="operation">Операция для добавления.</param>
        /// <returns>Добавленная операция с уникальным ID и другими атрибутами.</returns>
        public Operation Add(Operation operation)
        {
            // Генерация уникального ID для операции
            operation.Id = _operations.Any() ? _operations.Max(p => p.Id) + 1 : 1;

            // Заполнение дополнительными данными (по умолчанию)
            

            _operations.Add(operation);
            SaveToFile(); // Сохраняем изменения в файл

            return operation;
        }
    }
}
