using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    internal class InMemoryOperationRepository : IOperationRepository
    {
        private readonly List<Operation> _operations;

        // Конструктор, который инициализирует пустой список операций
        public InMemoryOperationRepository()
        {
            _operations = new List<Operation>();
        }

        // Получить все операции
        public IEnumerable<Operation> GetAll()
        {
            return _operations;
        }

        // Получить операцию по ID
        public Operation GetByID(int id)
        {
            return _operations.FirstOrDefault(p => p.Id == id);
        }

        // Добавить новую операцию
        public Operation Add(Operation operation)
        {
            // Присваиваем новый ID операции, если она не задана
            if (operation.Id == 0)
            {
                operation.Id = _operations.Any() ? _operations.Max(p => p.Id) + 1 : 1;
            }

            _operations.Add(operation);
            return operation;
        }

        // Обновить существующую операцию
        public Operation Update(Operation operation)
        {
            var existingOperation = GetByID(operation.Id);
            if (existingOperation == null)
            {
                throw new InvalidOperationException($"Product with ID {operation.Id} not found.");
            }

            Delete(existingOperation);
            Add(operation);

            return existingOperation;
        }

        // Удалить операцию по объекту
        public ulong Delete(Operation operation)
        {
            var existingOperation = GetByID(operation.Id);
            if (existingOperation == null)
            {
                return 0; // Операция не найдена
            }

            _operations.Remove(existingOperation);
            return (ulong)operation.Id;
        }
    }
}
