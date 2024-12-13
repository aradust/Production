using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    internal class InMemoryToolsRepository : IToolsRepository
    {
        private readonly List<Tools> _tools;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryToolsRepository()
        {
            _tools = new List<Tools>();
        }

        // Получить все продукты
        public IEnumerable<Tools> GetAll()
        {
            return _tools;
        }

        // Получить продукт по ID
        public Tools GetByID(int id)
        {
            return _tools.FirstOrDefault(p => p.TypeId == id);
        }

        // Добавить новый продукт
        public Tools Add(Tools tools)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (tools.TypeId == 0)
            {
                tools.TypeId = _tools.Any() ? _tools.Max(p => p.TypeId) + 1 : 1;
            }
            _tools.Add(tools);
            return tools;
        }

        // Обновить существующий продукт
        public Tools Update(Tools tools)
        {
            var existingOperation = GetByID(tools.TypeId);
            if (existingOperation == null)
            {
                throw new InvalidOperationException($"Product with ID {tools.TypeId} not found.");
            }

            //Delete(existingProduct);
            Add(tools);

            return existingOperation;
        }
        // Удалить продукт по объекту
        public ulong Delete(int id)
        {
            var existingTools = _tools.FirstOrDefault(p => p.TypeId == id);
            if (existingTools == null)
            {
                return 0; // Продукт не найден
            }

            _tools.Remove(existingTools);
            return (ulong)id;
        }
    }
}
