using Production;

using System.ComponentModel;

/// <summary>
/// Класс-наследник, добавляющий логирование для операций.
/// </summary>
public class OperationUsecaseWithLogging : OperationUsecase
{
    private const string LogFilePath = "log.txt";

    public OperationUsecaseWithLogging(IOperationRepository operationRepository) : base(operationRepository)
    {
    }

    public override BindingList<Operation> GetAllOperations()
    {
        Log("GetAllOperations - Start");
        var result = base.GetAllOperations();
        Log("GetAllOperations - End");
        return result;
    }

    public override Operation GetOperationById(int id)
    {
        Log($"GetOperationById({id}) - Start");
        var result = base.GetOperationById(id);
        Log($"GetOperationById({id}) - End");
        return result;
    }

    public override Operation AddOperation(Operation operation)
    {
        Log("AddOperation - Start");
        var result = base.AddOperation(operation);
        Log("AddOperation - End");
        return result;
    }

    public override Operation UpdateOperation(Operation operation)
    {
        Log("UpdateOperation - Start");
        var result = base.UpdateOperation(operation);
        Log("UpdateOperation - End");
        return result;
    }

    public override ulong DeleteOperation(int Id)
    {
        Log($"DeleteOperation({Id}) - Start");
        var result = base.DeleteOperation(Id);
        Log($"DeleteOperation({Id}) - End");
        return result;
    }

    private void Log(string message)
    {
        File.AppendAllText(LogFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
    }
}
