using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryToolsRepository : IToolsRepository
    {
        protected List<Tools> _tools;

        // Конструктор, который инициализирует пустой список инструментов
        public InMemoryToolsRepository()
        {
            _tools = new List<Tools>();
        }

        // Получить все инструменты
        virtual public IEnumerable<Tools> GetAll()
        {
            return _tools;
        }

        // Получить инструмент по ID
        virtual public Tools GetByID(int id)
        {
            return _tools.FirstOrDefault(t => t.Id == id);
        }

        // Добавить новый инструмент
        virtual public Tools Add(Tools tools)
        {
            // Присваиваем новый ID инструменту, если он не задан
            if (tools.Id == 0)
            {
                tools.Id = _tools.Any() ? _tools.Max(t => t.Id) + 1 : 1;
            }
            _tools.Add(tools);
            return tools;
        }

        // Обновить существующий инструмент
        virtual public Tools Update(Tools tools)
        {
            var existingTool = GetByID(tools.TypeId);
            if (existingTool == null)
            {
                throw new InvalidOperationException($"Tool with ID {tools.TypeId} not found.");
            }

            Delete(existingTool.Id);
            Add(tools);

            return existingTool;
        }

        // Удалить инструмент по ID
        virtual public ulong Delete(int id)
        {
            var existingTools = _tools.FirstOrDefault(t => t.Id == id);
            if (existingTools == null)
            {
                return 0; // Инструмент не найден
            }

            _tools.Remove(existingTools);
            return (ulong)id;
        }
    }
}
