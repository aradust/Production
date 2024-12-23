using System;
using System.ComponentModel;
using System.IO;

namespace Production
{
    /// <summary>
    /// Логирующий наследник для работы с нарядами.
    /// </summary>
    public class LoggingWorkOrderUsecase : WorkOrderUsecase
    {
        private const string LogFilePath = "log.txt";

        /// <summary>
        /// Конструктор класса <see cref="LoggingWorkOrderUsecase"/>.
        /// </summary>
        /// <param name="workOrderRepository">Репозиторий для работы с нарядами.</param>
        public LoggingWorkOrderUsecase(IWorkOrderRepository workOrderRepository)
            : base(workOrderRepository)
        {
        }

        private void Log(string message)
        {
            try
            {
                File.AppendAllText(LogFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка при записи в лог: {ex.Message}");
            }
        }

        public override BindingList<WorkOrder> GetAllWorkOrders()
        {
            Log("Получение всех нарядов.");
            return base.GetAllWorkOrders();
        }

        public override WorkOrder GetWorkOrderById(int id)
        {
            Log($"Получение наряда с ID: {id}.");
            return base.GetWorkOrderById(id);
        }

        public override WorkOrder AddWorkOrder(WorkOrder workOrder)
        {
            Log($"Добавление нового наряда: {workOrder.Id}.");
            return base.AddWorkOrder(workOrder);
        }

        public override WorkOrder UpdateWorkOrder(WorkOrder workOrder)
        {
            Log($"Обновление наряда с ID: {workOrder?.Id}.");
            return base.UpdateWorkOrder(workOrder);
        }

        public override ulong DeleteWorkOrder(int id)
        {
            Log($"Удаление наряда с ID: {id}.");
            return base.DeleteWorkOrder(id);
        }
    }
}
