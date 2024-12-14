using System;
using System.Collections.Generic;
using System.Linq;

namespace Production
{
    public class InMemoryOperationRepository : IOperationRepository
    {
        protected List<Operation> _operations;

        // Конструктор, который инициализирует пустой список операций
        public InMemoryOperationRepository()
        {
            _operations = new List<Operation>();
        }

        // Получить все операции
        virtual public IEnumerable<Operation> GetAll()
        {
            return _operations;
        }

        // Получить операцию по ID
        virtual public Operation GetByID(int id)
        {
            return _operations.FirstOrDefault(o => o.Id == id);
        }

        // Добавить новую операцию
        virtual public Operation Add(Operation operation)
        {
            // Присваиваем новый ID операции, если он не задан
            if (operation.Id == 0)
            {
                operation.Id = _operations.Any() ? _operations.Max(o => o.Id) + 1 : 1;
            }
            _operations.Add(operation);
            return operation;
        }

        // Обновить существующую операцию
        virtual public Operation Update(Operation operation)
        {
            var existingOperation = GetByID(operation.Id);
            if (existingOperation == null)
            {
                throw new InvalidOperationException($"Operation with ID {operation.Id} not found.");
            }

            Delete(existingOperation.Id);
            Add(operation);

            return existingOperation;
        }

        // Удалить операцию по ID
        virtual public ulong Delete(int id)
        {
            var existingOperation = _operations.FirstOrDefault(o => o.Id == id);
            if (existingOperation == null)
            {
                return 0; // Операция не найдена
            }

            _operations.Remove(existingOperation);
            return (ulong)id;
        }
    }
}
