using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с чертежами.
    /// Использует репозиторий <see cref="IDrawingRepository"/> для выполнения операций с чертежами.
    /// </summary>
    public class DrawingUsecase
    {
        protected readonly IDrawingRepository _drawingRepository;

        /// <summary>
        /// Конструктор класса <see cref="DrawingUsecase"/>.
        /// </summary>
        /// <param name="drawingRepository">Репозиторий для работы с чертежами.</param>
        public DrawingUsecase(IDrawingRepository drawingRepository)
        {
            _drawingRepository = drawingRepository ?? throw new ArgumentNullException(nameof(drawingRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все чертежи.
        /// </summary>
        /// <returns>Список всех чертежей.</returns>
        public virtual BindingList<Drawing> GetAllDrawings()
        {
            return new BindingList<Drawing>(_drawingRepository.GetAll().ToList());
        }

        /// <summary>
        /// Получает чертеж по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор чертежа.</param>
        /// <returns>Чертеж с указанным идентификатором, или <c>null</c>, если чертеж не найден.</returns>
        public virtual Drawing GetDrawingById(int id)
        {
            return _drawingRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый чертеж.
        /// </summary>
        /// <param name="drawing">Чертеж, который нужно добавить.</param>
        /// <returns>Добавленный чертеж с обновленными данными.</returns>
        public virtual Drawing AddDrawing(Drawing drawing)
        {
            if (drawing == null)
            {
                throw new ArgumentNullException(nameof(drawing), "Чертеж не может быть null.");
            }

            return _drawingRepository.Add(drawing);
        }

        /// <summary>
        /// Обновляет данные существующего чертежа.
        /// </summary>
        /// <param name="drawing">Обновленные данные чертежа.</param>
        /// <returns>Обновленный чертеж.</returns>
        public virtual Drawing UpdateDrawing(Drawing drawing)
        {
            if (drawing == null)
            {
                throw new ArgumentNullException(nameof(drawing), "Чертеж не может быть null.");
            }

            return _drawingRepository.Update(drawing);
        }

        /// <summary>
        /// Удаляет чертеж.
        /// </summary>
        /// <param name="Id">Идентификатор чертежа, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного чертежа или <c>0</c>, если удаление не удалось.</returns>
        public virtual ulong DeleteDrawing(int Id)
        {
            return _drawingRepository.Delete(Id);
        }
    }
}
