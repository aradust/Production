using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryToolTypeRepository : IToolTypeRepository
    {
        protected List<ToolType> _toolTypes;
        protected int _nextId;

        // Конструктор, который инициализирует пустой список типов инструментов
        public InMemoryToolTypeRepository()
        {
            _toolTypes = new List<ToolType>();
            _nextId = 1;
        }

        // Получить все типы инструментов
        virtual public IList<ToolType> GetAll()
        {
            return _toolTypes.ToList();
        }

        // Получить тип инструмента по ID
        virtual public ToolType GetById(int id)
        {
            return _toolTypes.FirstOrDefault(t => t.Id == id);
        }

        // Добавить новый тип инструмента
        virtual public ToolType Add(ToolType toolType)
        {
            if (toolType == null)
            {
                throw new ArgumentNullException(nameof(toolType));
            }

            toolType.Id = _nextId++;
            _toolTypes.Add(toolType);
            return toolType;
        }

        // Обновить существующий тип инструмента
        virtual public ToolType Update(ToolType toolType)
        {
            if (toolType == null)
            {
                throw new ArgumentNullException(nameof(toolType));
            }

            var existing = GetById(toolType.Id);
            if (existing == null)
            {
                throw new KeyNotFoundException($"ToolType with ID {toolType.Id} not found.");
            }

            Delete(toolType.Id);
            return Add(toolType);
        }

        // Удалить тип инструмента по ID
        virtual public int Delete(int id)
        {
            var toolType = GetById(id);
            if (toolType == null)
            {
                return 0;
            }

            _toolTypes.Remove(toolType);
            return 1;
        }
    }
}
