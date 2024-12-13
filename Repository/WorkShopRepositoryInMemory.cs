using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    internal class InMemoryWorkShopRepository : IWorkShopRepository
    {
        private readonly List<WorkShop> _workShops;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryWorkShopRepository()
        {
            _workShops = new List<WorkShop>();
        }

        // Получить все продукты
        public IEnumerable<WorkShop> GetAll()
        {
            return _workShops;
        }

        // Получить продукт по ID
        public WorkShop GetByID(int id)
        {
            return _workShops.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый продукт
        public WorkShop Add(WorkShop workShop)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (workShop.Id == 0)
            {
                workShop.Id = _workShops.Any() ? _workShops.Max(p => p.Id) + 1 : 1;
            }
            _workShops.Add(workShop);
            return workShop;
        }

        // Обновить существующий продукт
        public WorkShop Update(WorkShop workShop)
        {
            var existingWorkShop = GetByID(workShop.Id);
            if (existingWorkShop == null)
            {
                throw new InvalidOperationException($"Product with ID {workShop.Id} not found.");
            }

            //Delete(existingProduct);
            Add(workShop);

            return existingWorkShop;
        }

        // Удалить продукт по объекту
        public ulong Delete(int id)
        {
            var existingWorkShop = _workShops.FirstOrDefault(p => p.Id == id);
            if (existingWorkShop == null)
            {
                return 0; // Продукт не найден
            }

            _workShops.Remove(existingWorkShop);
            return (ulong)id;
        }
    }
}
