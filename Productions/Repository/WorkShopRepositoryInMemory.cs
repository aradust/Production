using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryWorkShopRepository : IWorkShopRepository
    {
        protected List<WorkShop> _workShops;

        // Конструктор, который инициализирует пустой список цехов
        public InMemoryWorkShopRepository()
        {
            _workShops = new List<WorkShop>();
        }

        // Получить все цехи
        virtual public IEnumerable<WorkShop> GetAll()
        {
            return _workShops;
        }

        // Получить цех по ID
        virtual public WorkShop GetByID(int id)
        {
            return _workShops.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый цех
        virtual public WorkShop Add(WorkShop workShop)
        {
            // Присваиваем новый ID цеху, если он не задан
            if (workShop.Id == 0)
            {
                workShop.Id = _workShops.Any() ? _workShops.Max(p => p.Id) + 1 : 1;
            }
            _workShops.Add(workShop);
            return workShop;
        }

        // Обновить существующий цех
        virtual public WorkShop Update(WorkShop workShop)
        {
            var existingWorkShop = GetByID(workShop.Id);
            if (existingWorkShop == null)
            {
                throw new InvalidOperationException($"Product with ID {workShop.Id} not found.");
            }

            Add(workShop);

            return existingWorkShop;
        }

        // Удалить цех по ID
        virtual public ulong Delete(int id)
        {
            var existingWorkShop = _workShops.FirstOrDefault(p => p.Id == id);
            if (existingWorkShop == null)
            {
                return 0; // Цех не найден
            }

            _workShops.Remove(existingWorkShop);
            return (ulong)id;
        }
    }
}
