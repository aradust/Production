using System;
using System.ComponentModel;
using System.IO;

namespace Production
{
    /// <summary>
    /// Логирующий наследник для работы с чертежами.
    /// </summary>
    internal class LoggingDrawingUsecase : DrawingUsecase
    {
        private const string LogFilePath = "log.txt";

        /// <summary>
        /// Конструктор класса <see cref="LoggingDrawingUsecase"/>.
        /// </summary>
        /// <param name="drawingRepository">Репозиторий для работы с чертежами.</param>
        public LoggingDrawingUsecase(IDrawingRepository drawingRepository)
            : base(drawingRepository)
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

        public override BindingList<Drawing> GetAllDrawings()
        {
            Log("Получение всех чертежей.");
            return base.GetAllDrawings();
        }

        public override Drawing GetDrawingById(int id)
        {
            Log($"Получение чертежа с ID: {id}.");
            return base.GetDrawingById(id);
        }

        public override Drawing AddDrawing(Drawing drawing)
        {
            Log($"Добавление нового чертежа: {drawing?.Name ?? "без названия"}.");
            return base.AddDrawing(drawing);
        }

        public override Drawing UpdateDrawing(Drawing drawing)
        {
            Log($"Обновление чертежа с ID: {drawing?.Id}.");
            return base.UpdateDrawing(drawing);
        }

        public override ulong DeleteDrawing(int id)
        {
            Log($"Удаление чертежа с ID: {id}.");
            return base.DeleteDrawing(id);
        }
    }
}
