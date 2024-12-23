using Production;

using System.ComponentModel;

/// <summary>
/// Класс-наследник, реализующий логирование для методов ToolsUsecase.
/// </summary>
public class ToolsUsecaseWithLogging : ToolsUsecase
{
    private const string LogFilePath = "log.txt";

    public ToolsUsecaseWithLogging(IToolsRepository toolsRepository) : base(toolsRepository)
    {
    }

    public override BindingList<Tools> GetAllTools()
    {
        Log("Начало выполнения GetAllTools");
        var result = base.GetAllTools();
        Log("Завершение выполнения GetAllTools");
        return result;
    }

    public override Tools GetToolsById(int id)
    {
        Log($"Начало выполнения GetToolsById с параметром id={id}");
        var result = base.GetToolsById(id);
        Log($"Завершение выполнения GetToolsById с параметром id={id}");
        return result;
    }

    public override Tools AddTools(Tools tools)
    {
        Log("Начало выполнения AddTools");
        var result = base.AddTools(tools);
        Log("Завершение выполнения AddTools");
        return result;
    }

    public override Tools UpdateTools(Tools tools)
    {
        Log("Начало выполнения UpdateTools");
        var result = base.UpdateTools(tools);
        Log("Завершение выполнения UpdateTools");
        return result;
    }

    public override ulong DeleteTools(int Id)
    {
        Log($"Начало выполнения DeleteTools с параметром Id={Id}");
        var result = base.DeleteTools(Id);
        Log($"Завершение выполнения DeleteTools с параметром Id={Id}");
        return result;
    }

    private void Log(string message)
    {
        using (var writer = new System.IO.StreamWriter(LogFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}