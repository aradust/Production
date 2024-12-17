using Newtonsoft.Json;
using Production;
using System.Collections.Generic;
using System.IO;
/// <summary>
/// Класс для управления типами инструментов с сохранением данных в JSON-файл.
/// </summary>
public class FileToolTypeRepository : InMemoryToolTypeRepository
{
    /// <summary>
    /// Путь к JSON-файлу, в котором хранятся данные типов инструментов.
    /// </summary>
    private readonly string _filePath;

    /// <summary>
    /// Создает новый экземпляр класса <see cref="FileToolTypeRepository"/> и загружает данные из указанного файла.
    /// </summary>
    /// <param name="filePath">Путь к JSON-файлу для хранения данных типов инструментов.</param>
    public FileToolTypeRepository(string filePath)
    {
        _filePath = filePath;
        _toolTypes = LoadFromFile(); // Загружаем данные из файла при инициализации
    }

    /// <summary>
    /// Загружает данные из JSON-файла.
    /// Если файл отсутствует, возвращает пустую коллекцию.
    /// </summary>
    /// <returns>Коллекция типов инструментов, загруженных из файла.</returns>
    private List<ToolType> LoadFromFile()
    {
        if (!File.Exists(_filePath))
        {
            return new List<ToolType>(); // Если файла нет, возвращаем пустой список
        }

        var jsonString = File.ReadAllText(_filePath); // Чтение содержимого файла
        return JsonConvert.DeserializeObject<List<ToolType>>(jsonString) ?? new List<ToolType>(); // Десериализация JSON в коллекцию объектов
    }

    /// <summary>
    /// Сохраняет текущую коллекцию типов инструментов в JSON-файл.
    /// </summary>
    private void SaveToFile()
    {
        var jsonString = JsonConvert.SerializeObject(_toolTypes, Formatting.Indented); // Сериализация коллекции в JSON с отступами
        File.WriteAllText(_filePath, jsonString); // Запись данных в файл
    }

    /// <summary>
    /// Добавляет новый тип инструмента в репозиторий и сохраняет изменения в файл.
    /// </summary>
    /// <param name="toolType">Тип инструмента для добавления.</param>
    /// <returns>Добавленный тип инструмента с уникальным ID и другими атрибутами.</returns>
    public override ToolType Add(ToolType toolType)
    {
        var addedToolType = base.Add(toolType); // Вызов метода базового класса для добавления
        SaveToFile(); // Сохраняем изменения в файл
        return addedToolType;
    }

    /// <summary>
    /// Обновляет информацию о существующем типе инструмента.
    /// </summary>
    /// <param name="toolType">Тип инструмента с обновленными данными.</param>
    /// <returns>Обновленный тип инструмента или null, если тип не найден.</returns>
    public override ToolType Update(ToolType toolType)
    {
        var updatedToolType = base.Update(toolType); // Вызов метода базового класса для обновления
        SaveToFile(); // Сохраняем изменения в файл
        return updatedToolType;
    }

    /// <summary>
    /// Удаляет тип инструмента из репозитория.
    /// </summary>
    /// <param name="id">Уникальный идентификатор типа инструмента для удаления.</param>
    /// <returns>Результат удаления.</returns>
    public override int Delete(int id)
    {
        var result = base.Delete(id); // Вызов метода базового класса для удаления
        SaveToFile(); // Сохраняем изменения в файл
        return result;
    }
}
