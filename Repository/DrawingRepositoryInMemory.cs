using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryDrawingRepository : IDrawingRepository
    {
        protected List<Drawing> _drawings;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryDrawingRepository()
        {
            _drawings = new List<Drawing>();
        }

        // Получить все продукты
        virtual public IEnumerable<Drawing> GetAll()
        {
            return _drawings;
        }

        // Получить продукт по ID
        virtual public Drawing GetByID(int id)
        {
            return _drawings.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый продукт
        virtual public Drawing Add(Drawing drawing)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (drawing.Id == 0)
            {
                drawing.Id = _drawings.Any() ? _drawings.Max(p => p.Id) + 1 : 1;
            }
            _drawings.Add(drawing);
            return drawing;
        }

        // Обновить существующий продукт
        virtual public Drawing Update(Drawing drawing)
        {
            var existingDrawing = GetByID(drawing.Id);
            if (existingDrawing == null)
            {
                throw new InvalidOperationException($"Product with ID {drawing.Id} not found.");
            }

            Delete(drawing.Id);
            Add(drawing);

            return existingDrawing;
        }

        // Удалить продукт по объекту
        virtual public ulong Delete(int id)
        {
            var existingDrawing = _drawings.FirstOrDefault(p => p.Id == id);
            if (existingDrawing == null)
            {
                return 0; // Продукт не найден
            }

            _drawings.Remove(existingDrawing);
            return (ulong)id;
        }
    }
}
