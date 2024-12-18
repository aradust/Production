using System;
using Newtonsoft.Json;

/// <summary>
/// Представляет информацию о материале, используемом в производственном процессе.
/// </summary>
public class Material
{
    /// <summary>
    /// Приватное поле для хранения уникального идентификатора материала.
    /// </summary>
    private int _Id;

    /// <summary>
    /// Приватное поле для хранения названия материала.
    /// </summary>
    private string _Name;

    /// <summary>
    /// Приватное поле для хранения описания материала.
    /// </summary>
    private string _Description;

    /// <summary>
    /// Приватное поле, указывающее, является ли материал расходуемым.
    /// </summary>
    private bool _IsConsumable;

    /// <summary>
    /// Уникальный идентификатор материала.
    /// </summary>
    /// <value>Целое число, представляющее уникальный идентификатор.</value>
    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }

    /// <summary>
    /// Название материала.
    /// </summary>
    /// <value>Строка, содержащая название материала.</value>
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    /// <summary>
    /// Описание материала.
    /// </summary>
    /// <value>Строка, содержащая описание материала.</value>
    public string Description
    {
        get { return _Description; }
        set { _Description = value; }
    }

    /// <summary>
    /// Указывает, является ли материал расходуемым.
    /// </summary>
    /// <value>Логическое значение: true, если материал расходуемый; false в противном случае.</value>
    public bool IsConsumable
    {
        get { return _IsConsumable; }
        set { _IsConsumable = value; }
    }

    public Material() { }
    /// <summary>
    /// Создает новый экземпляр класса <see cref="Material"/> с указанными параметрами.
    /// </summary>
    /// <param name="id">Уникальный идентификатор материала.</param>
    /// <param name="name">Название материала.</param>
    /// <param name="description">Описание материала.</param>
    /// <param name="isConsumable">Логическое значение, указывающее, является ли материал расходуемым.</param>
    public Material(int id, string name, string description, bool isConsumable)
    {
        _Name = name;
        _Description = description;
        _Id = id;
        _IsConsumable = isConsumable;
    }

    /// <summary>
    /// Создает новый экземпляр класса <see cref="Material"/> с заданным названием.
    /// Используется для десериализации из JSON.
    /// </summary>
    /// <param name="name">Название материала.</param>
    [JsonConstructor]
    public Material(string name)
    {
        _Name = name;
    }
}
