using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления нарядами с сохранением данных в JSON-файл.
    /// Реализует интерфейс <see cref="IWorkOrderRepository"/>.
    /// </summary>
    public class FileWorkOrderRepository : InMemoryWorkOrderRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о нарядах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileWorkOrderRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о нарядах.</param>
        public FileWorkOrderRepository(string filePath)
        {
            _filePath = filePath;
            _workOrders = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция нарядов, загруженных из файла.</returns>
        private List<WorkOrder> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<WorkOrder>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath); // Чтение содержимого файла
            return JsonConvert.DeserializeObject<List<WorkOrder>>(jsonString) ?? new List<WorkOrder>(); // Десериализация JSON в коллекцию объектов
        }

        /// <summary>
        /// Сохраняет текущую коллекцию нарядов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_workOrders, Formatting.Indented); // Сериализация коллекции в JSON с отступами
            File.WriteAllText(_filePath, jsonString); // Запись данных в файл
        }

        /// <summary>
        /// Добавляет новый наряд в репозиторий и сохраняет изменения в файл.
        /// Наряду автоматически присваивается уникальный идентификатор, текущая дата выполнения и стоимость.
        /// </summary>
        /// <param name="workOrder">Наряд для добавления.</param>
        /// <returns>Добавленный наряд с уникальным ID, датой выполнения и стоимостью.</returns>
        public override WorkOrder Add(WorkOrder workOrder)
        {
            var added = base.Add(workOrder);
            SaveToFile(); // Сохраняем изменения в файл

            return added;
        }

        /// <summary>
        /// Удаляет наряд из репозитория.
        /// </summary>
        /// <param name="id">Идентификатор наряда для удаления.</param>
        /// <returns>ID удаленного наряда.</returns>
        public override ulong Delete(int id)
        {
            var deleted = base.Delete(id);
            SaveToFile(); // Сохраняем изменения в файл
            return (ulong)deleted;
        }

        /// <summary>
        /// Возвращает все наряды из репозитория.
        /// </summary>
        /// <returns>Коллекция всех нарядов.</returns>
        public override IEnumerable<WorkOrder> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Получает наряд по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор наряда.</param>
        /// <returns>Наряд с указанным ID или null, если наряд не найден.</returns>
        public override WorkOrder GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующем наряде в репозитории.
        /// </summary>
        /// <param name="workOrder">Наряд с обновленными данными.</param>
        /// <returns>Обновленный наряд или null, если наряд не найден.</returns>
        public override WorkOrder Update(WorkOrder workOrder)
        {
            var updated = base.Update(workOrder);
            SaveToFile();
            return updated;
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию нарядов.
        /// </summary>
        /// <returns>Коллекция нарядов, загруженных из файла.</returns>
        private IEnumerable<WorkOrder> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<WorkOrder>();

            var json = File.ReadAllText(_filePath); // Чтение содержимого файла
            return JsonConvert.DeserializeObject<List<WorkOrder>>(json) ?? new List<WorkOrder>(); // Десериализация JSON в коллекцию объектов
        }
    }
}
