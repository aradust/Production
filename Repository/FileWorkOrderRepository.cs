using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления продуктами с сохранением данных в JSON-файл.
    /// Реализует интерфейс <see cref="IWorkOrderRepository"/>.
    /// </summary>
    public class FileWorkOrderRepository : IWorkOrderRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о продуктах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Коллекция продуктов, загруженных из файла.
        /// </summary>
        private List<WorkOrder> _workOrders;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileWorkOrderRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о продуктах.</param>
        public FileWorkOrderRepository(string filePath)
        {
            _filePath = filePath;
            _workOrders = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private List<WorkOrder> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<WorkOrder>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<WorkOrder>>(jsonString) ?? new List<WorkOrder>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию продуктов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_workOrders, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Добавляет новый продукт в репозиторий и сохраняет изменения в файл.
        /// Продукту автоматически присваивается уникальный идентификатор, текущая дата производства и стоимость.
        /// </summary>
        /// <param name="workOrder">Продукт для добавления.</param>
        /// <returns>Добавленный продукт с уникальным ID, датой производства и стоимостью.</returns>
        public WorkOrder Add(WorkOrder workOrder)
        {
            workOrder.Id = _workOrders.Any() ? _workOrders.Max(p => p.Id) + 1 : 1; // Генерация уникального ID
           

            _workOrders.Add(workOrder);
            SaveToFile(); // Сохраняем изменения в файл

            return workOrder;
        }

      
       

        public ulong Delete(int id)
        {
            var workOrderToRemove = _workOrders.FirstOrDefault(p => p.Id == id);
            if (workOrderToRemove != null)
            {
                _workOrders.Remove(workOrderToRemove);
                SaveToFile(); // Сохраняем изменения в файл
            }
            if (workOrderToRemove == null)
            {
                return 0; // Продукт не найден
            }
            return (ulong)id;
        }

        /// <summary>
        /// Возвращает все продукты из репозитория.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        public IEnumerable<WorkOrder> GetAll()
        {
            return ReadFromFile();
        }

        /// <summary>
        /// Получает продукт по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным ID или null, если продукт не найден.</returns>
        public WorkOrder GetByID(int id)
        {
            return ReadFromFile().FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Обновляет информацию о существующем продукте в репозитории.
        /// </summary>
        /// <param name="workOrder">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт или null, если продукт не найден.</returns>
        public WorkOrder Update(WorkOrder workOrder)
        {
            var workOrders = ReadFromFile().ToList();
            var existingWorkOrder = workOrders.FirstOrDefault(p => p.Id == workOrder.Id);
            if (existingWorkOrder != null)
            {
                workOrders.Remove(existingWorkOrder);
                workOrders.Add(workOrder);
                WriteToFile(workOrders); // Сохраняем обновленную коллекцию в файл
            }
            return existingWorkOrder;
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию продуктов.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private IEnumerable<WorkOrder> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<WorkOrder>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<WorkOrder>>(json) ?? new List<WorkOrder>();
        }

        /// <summary>
        /// Записывает обновленную коллекцию продуктов в файл.
        /// </summary>
        /// <param name="workOrders">Обновленная коллекция продуктов.</param>
        private void WriteToFile(IEnumerable<WorkOrder> workOrders)
        {
            var json = JsonConvert.SerializeObject(workOrders, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
