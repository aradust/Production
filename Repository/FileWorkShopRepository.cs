using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления продуктами с сохранением данных в JSON-файл.
    /// Реализует интерфейс <see cref="IWorkShopRepository"/>.
    /// </summary>
    public class FileWorkShopRepository : IWorkShopRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о продуктах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Коллекция продуктов, загруженных из файла.
        /// </summary>
        private List<WorkShop> _workShops;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileWorkShopRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о продуктах.</param>
        public FileWorkShopRepository(string filePath)
        {
            _filePath = filePath;
            _workShops = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private List<WorkShop> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<WorkShop>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<WorkShop>>(jsonString) ?? new List<WorkShop>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию продуктов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_workShops, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Добавляет новый продукт в репозиторий и сохраняет изменения в файл.
        /// Продукту автоматически присваивается уникальный идентификатор, текущая дата производства и стоимость.
        /// </summary>
        /// <param name="workShop">Продукт для добавления.</param>
        /// <returns>Добавленный продукт с уникальным ID, датой производства и стоимостью.</returns>
        public WorkShop Add(WorkShop workShop)
        {
            workShop.Id = _workShops.Any() ? _workShops.Max(p => p.Id) + 1 : 1; // Генерация уникального ID

            _workShops.Add(workShop);
            SaveToFile(); // Сохраняем изменения в файл

            return workShop;
        }

        /// <summary>
        /// Удаляет продукт из репозитория по объекту.
        /// </summary>
        /// <param name="workShop">Продукт для удаления.</param>
        /// <returns>ID удаленного продукта.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если продукт с указанным ID не найден.</exception>
        public ulong Delete(WorkShop workShop)
        {
            var existingWorkShop = _workShops.FirstOrDefault(p => p.Id == workShop.Id);

            if (existingWorkShop != null)
            {
                _workShops.Remove(existingWorkShop);
                SaveToFile(); // Сохраняем изменения в файл
                return (ulong)existingWorkShop.Id;
            }
            else
            {
                throw new InvalidOperationException($"Продукт с ID {workShop.Id} не найден.");
            }
        }

        /// <summary>
        /// Удаляет продукт из репозитория по ID.
        /// </summary>
        /// <param name="id">Идентификатор продукта для удаления.</param>
        /// <returns>ID удаленного продукта.</returns>
        public ulong Delete(int id)
        {
            var workShopToRemove = _workShops.FirstOrDefault(p => p.Id == id);
            if (workShopToRemove != null)
            {
                _workShops.Remove(workShopToRemove);
                SaveToFile(); // Сохраняем изменения в файл
            }
            if (workShopToRemove == null)
            {
                return 0; // Продукт не найден
            }
            return (ulong)id;
        }

        /// <summary>
        /// Возвращает все продукты из репозитория.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        public IEnumerable<WorkShop> GetAll()
        {
            return ReadFromFile();
        }

        /// <summary>
        /// Получает продукт по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным ID или null, если продукт не найден.</returns>
        public WorkShop GetByID(int id)
        {
            return ReadFromFile().FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Обновляет информацию о существующем продукте в репозитории.
        /// </summary>
        /// <param name="workShop">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт или null, если продукт не найден.</returns>
        public WorkShop Update(WorkShop workShop)
        {
            var workShops = ReadFromFile().ToList();
            var existingWorkShop = workShops.FirstOrDefault(p => p.Id == workShop.Id);
            if (existingWorkShop != null)
            {
                workShops.Remove(existingWorkShop);
                workShops.Add(workShop);
                WriteToFile(workShops); // Сохраняем обновленную коллекцию в файл
            }
            return existingWorkShop;
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию продуктов.
        /// </summary>
        /// <returns>Коллекция продуктов, загруженных из файла.</returns>
        private IEnumerable<WorkShop> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<WorkShop>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<WorkShop>>(json) ?? new List<WorkShop>();
        }

        /// <summary>
        /// Записывает обновленную коллекцию продуктов в файл.
        /// </summary>
        /// <param name="workShops">Обновленная коллекция продуктов.</param>
        private void WriteToFile(IEnumerable<WorkShop> workShops)
        {
            var json = JsonConvert.SerializeObject(workShops, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
