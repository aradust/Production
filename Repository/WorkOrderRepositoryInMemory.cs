using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    internal class InMemoryWorkOrderRepository : IWorkOrderRepository
    {
        private readonly List<WorkOrder> _workOrders;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryWorkOrderRepository()
        {
            _workOrders = new List<WorkOrder>();
        }

        // Получить все продукты
        public IEnumerable<WorkOrder> GetAll()
        {
            return _workOrders;
        }

        // Получить продукт по ID
        public WorkOrder GetByID(int id)
        {
            return _workOrders.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый продукт
        public WorkOrder Add(WorkOrder workOrder)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (workOrder.Id == 0)
            {
                workOrder.Id = _workOrders.Any() ? _workOrders.Max(p => p.Id) + 1 : 1;
            }
            _workOrders.Add(workOrder);
            return workOrder;
        }

        // Обновить существующий продукт
        public WorkOrder Update(WorkOrder workOrder)
        {
            var existingWorkOrder = GetByID(workOrder.Id);
            if (existingWorkOrder == null)
            {
                throw new InvalidOperationException($"WorkOrder with ID {workOrder.Id} not found.");
            }

            //Delete(existingWorkOrder);
            Add(workOrder);

            return existingWorkOrder;
        }

        // Удалить продукт по объекту
        public ulong Delete(int id)
        {
            var existingWorkOrder = _workOrders.FirstOrDefault(p => p.Id == id);
            if (existingWorkOrder == null)
            {
                return 0; // Продукт не найден
            }

            _workOrders.Remove(existingWorkOrder);
            return (ulong)id;
        }
    }
}
