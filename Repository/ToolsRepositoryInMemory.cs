using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    internal class InMemoryToolsRepository : IToolsRepository
    {
        private readonly List<Tools> _tools;

        // Конструктор, который инициализирует пустой список операций
        public InMemoryToolsRepository()
        {
            _tools = new List<Tools>();
        }

        // Получить все операции
        public IEnumerable<Tools> GetAll()
        {
            return _tools;
        }

        // Получить операцию по ID
        public Tools GetByID(int id)
        {
            return _tools.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новую операцию
        public Tools Add(Tools tools)
        {
            // Присваиваем новый ID операции, если она не задана
            if (tools.Id == 0)
            {
                tools.Id = _tools.Any() ? _tools.Max(p => p.Id) + 1 : 1;
            }

            _tools.Add(tools);
            return tools;
        }

        // Обновить существующую операцию
        public Tools Update(Tools tools)
        {
            var existingTools = GetByID(tools.Id);
            if (existingTools == null)
            {
                throw new InvalidOperationException($"Product with ID {tools.Id} not found.");
            }

            Delete(existingTools);
            Add(tools);

            return existingTools;
        }

        // Удалить операцию по объекту
        public ulong Delete(Tools tools)
        {
            var existingTools = GetByID(tools.Id);
            if (existingTools == null)
            {
                return 0; // Операция не найдена
            }

            _tools.Remove(existingTools);
            return (ulong)tools.Id;
        }
    }
}
