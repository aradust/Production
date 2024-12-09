using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    internal class InMemoryOperationRepository : IOperationRepository
    {
        private readonly List<Operation> _operations;

        // Конструктор, который инициализирует пустой список продуктов
        public InMemoryOperationRepository()
        {
            _operations = new List<Operation>();
        }

        // Получить все продукты
        public IEnumerable<Operation> GetAll()
        {
            return _operations;
        }

        // Получить продукт по ID
        public Operation GetByID(int id)
        {
            return _operations.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новый продукт
        public Operation Add(Operation operation)
        {
            // Присваиваем новый ID продукту, если он не задан
            if (operation.Id == 0)
            {
                operation.Id = _operations.Any() ? _operations.Max(p => p.Id) + 1 : 1;
            }
            _operations.Add(operation);
            return operation;
        }

        // Обновить существующий продукт
        public Operation Update(Operation operation)
        {
            var existingOperation = GetByID(operation.Id);
            if (existingOperation == null)
            {
                throw new InvalidOperationException($"Product with ID {operation.Id} not found.");
            }

            //Delete(existingProduct);
            Add(operation);

            return existingOperation;
        }

        // Удалить продукт по объекту
        public ulong Delete(int id)
        {
            var existingOperation = _operations.FirstOrDefault(p => p.Id == id);
            if (existingOperation == null)
            {
                return 0; // Продукт не найден
            }

            _operations.Remove(existingOperation);
            return (ulong)id;
        }
    }
}
