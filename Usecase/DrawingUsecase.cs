using System;
using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с продуктами.
    /// Использует репозиторий <see cref="IDrawingRepository"/> для выполнения операций с продуктами.
    /// </summary>
    internal class DrawingUsecase
    {
        private readonly IDrawingRepository _drawingRepository;

        /// <summary>
        /// Конструктор класса <see cref="DrawingionUsecase"/>.
        /// </summary>
        /// <param name="drawingRepository">Репозиторий для работы с продуктами.</param>
        public DrawingUsecase(IDrawingRepository drawingRepository)
        {
            _drawingRepository = drawingRepository ?? throw new ArgumentNullException(nameof(drawingRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Список всех продуктов.</returns>
        public IEnumerable<Drawing> GetAllDrawings()
        {
            return _drawingRepository.GetAll();
        }

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        public Drawing GetDrawingById(int id)
        {
            return _drawingRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый продукт.
        /// </summary>
        /// <param name="drawing">Продукт, который нужно добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными.</returns>
        public Drawing AddDrawing(Drawing drawing)
        {
            if (drawing == null)
            {
                throw new ArgumentNullException(nameof(drawing), "Продукт не может быть null.");
            }

            return _drawingRepository.Add(drawing);
        }

        /// <summary>
        /// Обновляет данные существующего продукта.
        /// </summary>
        /// <param name="drawing">Обновленные данные продукта.</param>
        /// <returns>Обновленный продукт.</returns>
        public Drawing UpdateDrawing(Drawing drawing)
        {
            if (drawing == null)
            {
                throw new ArgumentNullException(nameof(drawing), "Продукт не может быть null.");
            }

            return _drawingRepository.Update(drawing);
        }

        /// <summary>
        /// Удаляет продукт.
        /// </summary>
        /// <param name="drawing">Продукт, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта или <c>0</c>, если удаление не удалось.</returns>
        public ulong DeleteDrawing(int Id)
        {
            /* if (Id == null)
             {
                 //throw new ArgumentNullException(nameof(Drawing drawing.Id), "Продукт не может быть null.");
             }*/

            return _drawingRepository.Delete(Id);
        }
    }
}
