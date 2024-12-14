using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryWorkOrderRepository : IWorkOrderRepository
    {
        protected List<WorkOrder> _workOrders;

        // Конструктор, который инициализирует пустой список нарядов
        public InMemoryWorkOrderRepository()
        {
            _workOrders = new List<WorkOrder>();
        }

        // Получить все наряды
        virtual public IEnumerable<WorkOrder> GetAll()
        {
            return _workOrders;
        }

        // Получить наряд по ID
        virtual public WorkOrder GetByID(int id)
        {
            return _workOrders.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый наряд
        virtual public WorkOrder Add(WorkOrder workOrder)
        {
            // Присваиваем новый ID наряду, если он не задан
            if (workOrder.Id == 0)
            {
                workOrder.Id = _workOrders.Any() ? _workOrders.Max(p => p.Id) + 1 : 1;
            }
            _workOrders.Add(workOrder);
            return workOrder;
        }

        // Обновить существующий наряд
        virtual public WorkOrder Update(WorkOrder workOrder)
        {
            var existingWorkOrder = GetByID(workOrder.Id);
            if (existingWorkOrder == null)
            {
                throw new InvalidOperationException($"WorkOrder with ID {workOrder.Id} not found.");
            }

            Delete(existingWorkOrder.Id);
            Add(workOrder);

            return existingWorkOrder;
        }

        // Удалить наряд по ID
        virtual public ulong Delete(int id)
        {
            var existingWorkOrder = _workOrders.FirstOrDefault(p => p.Id == id);
            if (existingWorkOrder == null)
            {
                return 0; // Наряд не найден
            }

            _workOrders.Remove(existingWorkOrder);
            return (ulong)id;
        }
    }
}
