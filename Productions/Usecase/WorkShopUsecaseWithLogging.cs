using System;
using System.ComponentModel;
using System.IO;

namespace Production
{
    /// <summary>
    /// Логирующий наследник для работы с цехами.
    /// </summary>
    internal class LoggingWorkShopUsecase : WorkShopUsecase
    {
        private const string LogFilePath = "log.txt";

        /// <summary>
        /// Конструктор класса <see cref="LoggingWorkShopUsecase"/>.
        /// </summary>
        /// <param name="workShopRepository">Репозиторий для работы с цехами.</param>
        public LoggingWorkShopUsecase(IWorkShopRepository workShopRepository)
            : base(workShopRepository)
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

        public override BindingList<WorkShop> GetAllWorkShop()
        {
            Log("Получение всех цехов.");
            return base.GetAllWorkShop();
        }

        public override WorkShop GetWorkShopById(int id)
        {
            Log($"Получение цеха с ID: {id}.");
            return base.GetWorkShopById(id);
        }

        public override WorkShop AddWorkShop(WorkShop workShop)
        {
            Log($"Добавление нового цеха: {workShop?.Name ?? "без названия"}.");
            return base.AddWorkShop(workShop);
        }

        public override WorkShop UpdateWorkShop(WorkShop workShop)
        {
            Log($"Обновление цеха с ID: {workShop?.Id}.");
            return base.UpdateWorkShop(workShop);
        }

        public override ulong DeleteWorkShop(int id)
        {
            Log($"Удаление цеха с ID: {id}.");
            return base.DeleteWorkShop(id);
        }
    }
}
