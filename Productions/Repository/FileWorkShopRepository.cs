using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления цехами с сохранением данных в JSON-файл.
    /// Реализует интерфейс <see cref="IWorkShopRepository"/>.
    /// </summary>
    public class FileWorkShopRepository : InMemoryWorkShopRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о цехах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="FileWorkShopRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о цехах.</param>
        public FileWorkShopRepository(string filePath)
        {
            _filePath = filePath;
            _workShops = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция цехов, загруженных из файла.</returns>
        private List<WorkShop> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<WorkShop>(); // Если файла нет, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath); // Чтение содержимого файла
            return JsonConvert.DeserializeObject<List<WorkShop>>(jsonString) ?? new List<WorkShop>(); // Десериализация JSON в коллекцию объектов
        }

        /// <summary>
        /// Сохраняет текущую коллекцию цехов в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_workShops, Formatting.Indented); // Сериализация коллекции в JSON с отступами
            File.WriteAllText(_filePath, jsonString); // Запись данных в файл
        }

        /// <summary>
        /// Добавляет новый цех в репозиторий и сохраняет изменения в файл.
        /// Цеху автоматически присваивается уникальный идентификатор, а также дата создания и другие данные.
        /// </summary>
        /// <param name="workShop">Цех для добавления.</param>
        /// <returns>Добавленный цех с уникальным ID и обновленными данными.</returns>
        public override WorkShop Add(WorkShop workShop)
        {
            var newWorkShop = base.Add(workShop);
            SaveToFile(); // Сохраняем изменения в файл

            return newWorkShop;
        }

        /// <summary>
        /// Удаляет цех из репозитория по ID.
        /// </summary>
        /// <param name="id">Идентификатор цеха для удаления.</param>
        /// <returns>ID удаленного цеха.</returns>
        public override ulong Delete(int id)
        {
            var deleted = base.Delete(id);
            SaveToFile(); // Сохраняем изменения в файл
            return deleted;
        }

        /// <summary>
        /// Возвращает все цехи из репозитория.
        /// </summary>
        /// <returns>Коллекция всех цехов.</returns>
        public override IEnumerable<WorkShop> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Получает цех по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор цеха.</param>
        /// <returns>Цех с указанным ID или null, если цех не найден.</returns>
        public override WorkShop GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующем цехе в репозитории.
        /// </summary>
        /// <param name="workShop">Цех с обновленными данными.</param>
        /// <returns>Обновленный цех или null, если цех не найден.</returns>
        public override WorkShop Update(WorkShop workShop)
        {
            ReadFromFile();
            return base.Update(workShop);
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию цехов.
        /// </summary>
        /// <returns>Коллекция цехов, загруженных из файла.</returns>
        private IEnumerable<WorkShop> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<WorkShop>();

            var json = File.ReadAllText(_filePath); // Чтение содержимого файла
            return JsonConvert.DeserializeObject<List<WorkShop>>(json) ?? new List<WorkShop>(); // Десериализация JSON в коллекцию объектов
        }
    }
}
