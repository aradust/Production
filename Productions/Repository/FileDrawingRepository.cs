using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс для управления чертежами с сохранением данных в JSON-файл.
    /// Наследует функциональность <see cref="InMemoryDrawingRepository"/> и расширяет её поддержкой работы с файлами.
    /// </summary>
    public class FileDrawingRepository : InMemoryDrawingRepository
    {
        /// <summary>
        /// Путь к JSON-файлу, в котором хранятся данные о чертежах.
        /// </summary>
        private readonly string _filePath;

        /// <summary>
        /// Создаёт новый экземпляр класса <see cref="FileDrawingRepository"/> и загружает данные из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к JSON-файлу для хранения данных о чертежах.</param>
        public FileDrawingRepository(string filePath)
        {
            _filePath = filePath;
            _drawings = LoadFromFile(); // Загружаем данные из файла при инициализации
        }

        /// <summary>
        /// Загружает чертежи из JSON-файла.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция чертежей, загруженных из файла.</returns>
        private List<Drawing> LoadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Drawing>(); // Если файл отсутствует, возвращаем пустой список
            }

            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Drawing>>(jsonString) ?? new List<Drawing>();
        }

        /// <summary>
        /// Сохраняет текущую коллекцию чертежей в JSON-файл.
        /// </summary>
        private void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(_drawings, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        /// <summary>
        /// Добавляет новый чертёж в репозиторий и сохраняет изменения в файл.
        /// </summary>
        /// <param name="drawing">Чертёж для добавления.</param>
        /// <returns>Добавленный чертёж с присвоенным уникальным идентификатором.</returns>
        public override Drawing Add(Drawing drawing)
        {
            var newDrawing = base.Add(drawing);
            SaveToFile(); // Сохраняем изменения в файл
            return newDrawing;
        }

        /// <summary>
        /// Удаляет чертёж из репозитория по идентификатору и сохраняет изменения в файл.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого чертежа.</param>
        /// <returns>Идентификатор удалённого чертежа или 0, если чертёж не найден.</returns>
        public override ulong Delete(int id)
        {
            var deletedId = base.Delete(id);
            SaveToFile(); // Сохраняем изменения в файл
            return (ulong)deletedId;
        }

        /// <summary>
        /// Возвращает все чертежи из репозитория.
        /// </summary>
        /// <returns>Коллекция всех чертежей.</returns>
        public override IEnumerable<Drawing> GetAll()
        {
            ReadFromFile();
            return base.GetAll();
        }

        /// <summary>
        /// Получает чертёж по его уникальному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор чертежа.</param>
        /// <returns>Чертёж с указанным идентификатором или null, если он не найден.</returns>
        public override Drawing GetByID(int id)
        {
            ReadFromFile();
            return base.GetByID(id);
        }

        /// <summary>
        /// Обновляет информацию о существующем чертеже в репозитории и сохраняет изменения в файл.
        /// </summary>
        /// <param name="drawing">Чертёж с обновлёнными данными.</param>
        /// <returns>Обновлённый чертёж.</returns>
        public override Drawing Update(Drawing drawing)
        {
            var updatedDrawing = base.Update(drawing);
            SaveToFile(); // Сохраняем обновлённую коллекцию в файл
            return updatedDrawing;
        }

        /// <summary>
        /// Читает данные из файла и возвращает коллекцию чертежей.
        /// Если файл отсутствует, возвращает пустую коллекцию.
        /// </summary>
        /// <returns>Коллекция чертежей, загруженных из файла.</returns>
        private IEnumerable<Drawing> ReadFromFile()
        {
            if (!File.Exists(_filePath))
                return Enumerable.Empty<Drawing>();

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Drawing>>(json) ?? new List<Drawing>();
        }
    }
}
