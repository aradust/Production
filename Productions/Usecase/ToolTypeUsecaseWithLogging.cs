using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace Production.Usecase
{
    /// <summary>
    /// Логирующий наследник для работы с типами инструментов.
    /// </summary>
    public class LoggingToolTypeUsecase : ToolTypeUsecase
    {
        private const string LogFilePath = "log.txt";

        /// <summary>
        /// Конструктор класса <see cref="LoggingToolTypeUsecase"/>.
        /// </summary>
        /// <param name="repository">Репозиторий для работы с типами инструментов.</param>
        public LoggingToolTypeUsecase(IToolTypeRepository repository) : base(repository) { }

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

        public override ToolType GetById(int id)
        {
            Log($"Начало вызова метода GetById с ID: {id}");
            var result = base.GetById(id);
            Log($"Завершение вызова метода GetById с ID: {id}");
            return result;
        }

        public override BindingList<ToolType> GetAll()
        {
            Log("Начало вызова метода GetAll");
            var result = base.GetAll();
            Log("Завершение вызова метода GetAll");
            return result;
        }

        public override ToolType Add(ToolType toolType)
        {
            Log($"Начало вызова метода Add для инструмента: {toolType?.Name ?? "Без имени"}");
            var result = base.Add(toolType);
            Log($"Завершение вызова метода Add для инструмента: {toolType?.Name ?? "Без имени"}");
            return result;
        }

        public override int Delete(int id)
        {
            Log($"Начало вызова метода Delete с ID: {id}");
            var result = base.Delete(id);
            Log($"Завершение вызова метода Delete с ID: {id}");
            return result;
        }
    }
}
