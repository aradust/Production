using Newtonsoft.Json;
using Production;
using System.Collections.Generic;
using System.IO;

public class FileToolTypeRepository : InMemoryToolTypeRepository
{
    private readonly string _filePath;

    public FileToolTypeRepository(string filePath)
    {
        _filePath = filePath;
        _toolTypes = LoadFromFile();
    }

    private List<ToolType> LoadFromFile()
    {
        if (!File.Exists(_filePath))
        {
            return new List<ToolType>();
        }

        var jsonString = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<List<ToolType>>(jsonString) ?? new List<ToolType>();
    }

    private void SaveToFile()
    {
        var jsonString = JsonConvert.SerializeObject(_toolTypes, Formatting.Indented);
        File.WriteAllText(_filePath, jsonString);
    }

    public override ToolType Add(ToolType toolType)
    {
        var addedToolType = base.Add(toolType);
        SaveToFile();
        return addedToolType;
    }

    public override ToolType Update(ToolType toolType)
    {
        var updatedToolType = base.Update(toolType);
        SaveToFile();
        return updatedToolType;
    }

    public override int Delete(int id)
    {
        var result = base.Delete(id);
        SaveToFile();
        return result;
    }
}