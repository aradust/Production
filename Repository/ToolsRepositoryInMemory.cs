using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryToolsRepository : IToolsRepository
    {
        protected List<Tools> _tools;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryToolsRepository()
        {
            _tools = new List<Tools>();
        }

        // Получить все продукты
        virtual public IEnumerable<Tools> GetAll()
        {
            return _tools;
        }

        // Получить продукт по ID
        virtual public Tools GetByID(int id)
        {
            return _tools.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый продукт
        virtual public Tools Add(Tools tools)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (tools.Id == 0)
            {
                tools.Id = _tools.Any() ? _tools.Max(p => p.Id) + 1 : 1;
            }
            _tools.Add(tools);
            return tools;
        }

        // Обновить существующий продукт
        virtual public Tools Update(Tools tools)
        {
            var existingTool = GetByID(tools.TypeId);
            if (existingTool == null)
            {
                throw new InvalidOperationException($"Product with ID {tools.TypeId} not found.");
            }

            Delete(existingTool.Id);
            Add(tools);

            return existingTool;
        }
        // Удалить продукт по объекту
        virtual public ulong Delete(int id)
        {
            var existingTools = _tools.FirstOrDefault(p => p.Id == id);
            if (existingTools == null)
            {
                return 0; // Продукт не найден
            }

            _tools.Remove(existingTools);
            return (ulong)id;
        }
    }
}
