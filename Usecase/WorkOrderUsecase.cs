using System;
using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с нарядами.
    /// Использует репозиторий <see cref="IWorkOrderRepository"/> для выполнения операций с нарядами.
    /// </summary>
    public class WorkOrderUsecase
    {
        private readonly IWorkOrderRepository _workOrderRepository;

        /// <summary>
        /// Конструктор класса <see cref="WorkOrderUsecase"/>.
        /// </summary>
        /// <param name="workOrderRepository">Репозиторий для работы с нарядами.</param>
        public WorkOrderUsecase(IWorkOrderRepository workOrderRepository)
        {
            _workOrderRepository = workOrderRepository ?? throw new ArgumentNullException(nameof(workOrderRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все наряды.
        /// </summary>
        /// <returns>Список всех нарядов.</returns>
        public IEnumerable<WorkOrder> GetAllWorkOrders()
        {
            return _workOrderRepository.GetAll();
        }

        /// <summary>
        /// Получает наряд по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор наряда.</param>
        /// <returns>Наряд с указанным идентификатором, или <c>null</c>, если наряд не найден.</returns>
        public WorkOrder GetWorkOrderById(int id)
        {
            return _workOrderRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый наряд.
        /// </summary>
        /// <param name="workOrder">Наряд, который нужно добавить.</param>
        /// <returns>Добавленный наряд с обновленными данными.</returns>
        public WorkOrder AddWorkOrder(WorkOrder workOrder)
        {
            if (workOrder == null)
            {
                throw new ArgumentNullException(nameof(workOrder), "Наряд не может быть null.");
            }

            return _workOrderRepository.Add(workOrder);
        }

        /// <summary>
        /// Обновляет данные существующего наряда.
        /// </summary>
        /// <param name="workOrder">Обновленные данные наряда.</param>
        /// <returns>Обновленный наряд.</returns>
        public WorkOrder UpdateWorkOrder(WorkOrder workOrder)
        {
            if (workOrder == null)
            {
                throw new ArgumentNullException(nameof(workOrder), "Наряд не может быть null.");
            }

            return _workOrderRepository.Update(workOrder);
        }

        /// <summary>
        /// Удаляет наряд.
        /// </summary>
        /// <param name="Id">Идентификатор наряда, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного наряда или <c>0</c>, если удаление не удалось.</returns>
        public ulong DeleteWorkOrder(int Id)
        {
            /* if (Id == null)
             {
                 //throw new ArgumentNullException(nameof(WorkOrder workOrder.Id), "Наряд не может быть null.");
             }*/

            return _workOrderRepository.Delete(Id);
        }
    }
}
