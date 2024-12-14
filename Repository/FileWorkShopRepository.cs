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
    public class FileWorkShopRepository : InMemoryWorkShopRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о продуктах.
        /// </summary>
        private readonly string _filePath;

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
        public override WorkShop Add(WorkShop workShop)
        {
            var newWorkShop = base.Add(workShop);
            SaveToFile(); // Сохраняем изменения в файл

            return newWorkShop;
        }

        /// <summary>
        /// Удаляет продукт из репозитория по ID.
        /// </summary>
        /// <param name="id">Идентификатор продукта для удаления.</param>
        /// <returns>ID удаленного продукта.</returns>
        public override ulong Delete(int id)
        {
            var deleted = base.Delete(id);
            SaveToFile(); // Сохраняем изменения в файл
            return deleted;
        }

        /// <summary>
        /// Возвращает все продукты из репозитория.
        /// </summary>
        /// <returns>Коллекция всех продуктов.</returns>
        public override IEnumerable<WorkShop> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Получает продукт по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным ID или null, если продукт не найден.</returns>
        public override WorkShop GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующем продукте в репозитории.
        /// </summary>
        /// <param name="workShop">Продукт с обновленными данными.</param>
        /// <returns>Обновленный продукт или null, если продукт не найден.</returns>
        public override WorkShop Update(WorkShop workShop)
        {
            ReadFromFile();
            return base.Update(workShop);
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
    }
}
