using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Реализация репозитория чертежей в памяти, предоставляющая операции для управления коллекцией чертежей.
    /// </summary>
    public class InMemoryDrawingRepository : IDrawingRepository
    {
        /// <summary>
        /// Список чертежей, хранимых в памяти.
        /// </summary>
        protected List<Drawing> _drawings;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="InMemoryDrawingRepository"/> с пустым списком чертежей.
        /// </summary>
        public InMemoryDrawingRepository()
        {
            _drawings = new List<Drawing>();
        }

        /// <summary>
        /// Возвращает все чертежи из репозитория.
        /// </summary>
        /// <returns>Коллекция всех чертежей.</returns>
        virtual public IEnumerable<Drawing> GetAll()
        {
            return _drawings;
        }

        /// <summary>
        /// Возвращает чертеж по заданному идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор чертежа.</param>
        /// <returns>Чертеж с указанным идентификатором или null, если он не найден.</returns>
        virtual public Drawing GetByID(int id)
        {
            return _drawings.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Добавляет новый чертеж в репозиторий. 
        /// Если идентификатор чертежа равен 0, ему автоматически назначается новый уникальный идентификатор.
        /// </summary>
        /// <param name="drawing">Добавляемый чертеж.</param>
        /// <returns>Добавленный чертеж.</returns>
        virtual public Drawing Add(Drawing drawing)
        {
            if (drawing.Id == 0)
            {
                drawing.Id = _drawings.Any() ? _drawings.Max(p => p.Id) + 1 : 1;
            }
            _drawings.Add(drawing);
            return drawing;
        }

        /// <summary>
        /// Обновляет существующий чертеж в репозитории.
        /// </summary>
        /// <param name="drawing">Чертеж с обновлёнными данными.</param>
        /// <returns>Обновлённый чертеж.</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается, если чертеж с указанным идентификатором не найден.</exception>
        virtual public Drawing Update(Drawing drawing)
        {
            var existingDrawing = GetByID(drawing.Id);
            if (existingDrawing == null)
            {
                throw new InvalidOperationException($"Drawing with ID {drawing.Id} not found.");
            }

            Delete(drawing.Id);
            Add(drawing);

            return existingDrawing;
        }

        /// <summary>
        /// Удаляет чертеж из репозитория по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор удаляемого чертежа.</param>
        /// <returns>Идентификатор удалённого чертежа, либо 0, если чертеж не найден.</returns>
        virtual public ulong Delete(int id)
        {
            var existingDrawing = _drawings.FirstOrDefault(p => p.Id == id);
            if (existingDrawing == null)
            {
                return 0;
            }

            _drawings.Remove(existingDrawing);
            return (ulong)id;
        }
    }
}
