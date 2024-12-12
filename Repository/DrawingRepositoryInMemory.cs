using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    internal class InMemoryDrawingRepository : IDrawingRepository
    {
        private readonly List<Drawing> _drawing;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryDrawingRepository()
        {
            _drawing = new List<Drawing>();
        }

        // Получить все продукты
        public IEnumerable<Drawing> GetAll()
        {
            return _drawing;
        }

        // Получить продукт по ID
        public Drawing GetByID(int id)
        {
            return _drawing.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый продукт
        public Drawing Add(Drawing drawing)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (drawing.Id == 0)
            {
                drawing.Id = _drawing.Any() ? _drawing.Max(p => p.Id) + 1 : 1;
            }
            _drawing.Add(drawing);
            return drawing;
        }

        // Обновить существующий продукт
        public Drawing Update(Drawing drawing)
        {
            var existingDrawing = GetByID(drawing.Id);
            if (existingDrawing == null)
            {
                throw new InvalidOperationException($"Product with ID {drawing.Id} not found.");
            }

            //Delete(existingProduct);
            Add(drawing);

            return existingDrawing;
        }

        // Удалить продукт по объекту
        public ulong Delete(int id)
        {
            var existingDrawing = _drawing.FirstOrDefault(p => p.Id == id);
            if (existingDrawing == null)
            {
                return 0; // Продукт не найден
            }

            _drawing.Remove(existingDrawing);
            return (ulong)id;
        }
    }
}
