using System;
using System.Collections.Generic;

namespace Production 
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с продуктами.
    /// Использует репозиторий <see cref="IWorkOrderRepository"/> для выполнения операций с продуктами.
    /// </summary>
    public class WorkOrderUsecase
    {
        private readonly IWorkOrderRepository _workOrderRepository;

        /// <summary>
        /// Конструктор класса <see cref="WorkOrderionUsecase"/>.
        /// </summary>
        /// <param name="workOrderRepository">Репозиторий для работы с продуктами.</param>
        public WorkOrderUsecase(IWorkOrderRepository workOrderRepository)
        {
            _workOrderRepository = workOrderRepository ?? throw new ArgumentNullException(nameof(workOrderRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все продукты.
        /// </summary>
        /// <returns>Список всех продуктов.</returns>
        public IEnumerable<WorkOrder> GetAllWorkOrders()
        {
            return _workOrderRepository.GetAll();
        }

        /// <summary>
        /// Получает продукт по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <returns>Продукт с указанным идентификатором, или <c>null</c>, если продукт не найден.</returns>
        public WorkOrder GetWorkOrderById(int id)
        {
            return _workOrderRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый продукт.
        /// </summary>
        /// <param name="workOrder">Продукт, который нужно добавить.</param>
        /// <returns>Добавленный продукт с обновленными данными.</returns>
        public WorkOrder AddWorkOrder(WorkOrder workOrder)
        {
            if (workOrder == null)
            {
                throw new ArgumentNullException(nameof(workOrder), "Продукт не может быть null.");
            }

            return _workOrderRepository.Add(workOrder);
        }

        /// <summary>
        /// Обновляет данные существующего продукта.
        /// </summary>
        /// <param name="workOrder">Обновленные данные продукта.</param>
        /// <returns>Обновленный продукт.</returns>
        public WorkOrder UpdateWorkOrder(WorkOrder workOrder)
        {
            if (workOrder == null)
            {
                throw new ArgumentNullException(nameof(workOrder), "Продукт не может быть null.");
            }

            return _workOrderRepository.Update(workOrder);
        }

        /// <summary>
        /// Удаляет продукт.
        /// </summary>
        /// <param name="workOrder">Продукт, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного продукта или <c>0</c>, если удаление не удалось.</returns>
        public ulong DeleteWorkOrder(int Id)
        {
            /* if (Id == null)
             {
                 //throw new ArgumentNullException(nameof(WorkOrder workOrder.Id), "Продукт не может быть null.");
             }*/

            return _workOrderRepository.Delete(Id);
        }
    }
}
