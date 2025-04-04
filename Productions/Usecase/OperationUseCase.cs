﻿using System.ComponentModel;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с операциями.
    /// Использует репозиторий <see cref="IOperationRepository"/> для выполнения операций с операциями.
    /// </summary>
    public class OperationUsecase
    {
        protected readonly IOperationRepository _operationRepository;

        /// <summary>
        /// Конструктор класса <see cref="OperationUsecase"/>.
        /// </summary>
        /// <param name="operationRepository">Репозиторий для работы с операциями.</param>
        public OperationUsecase(IOperationRepository operationRepository)
        {
            _operationRepository = operationRepository ?? throw new ArgumentNullException(nameof(operationRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все операции.
        /// </summary>
        /// <returns>Список всех операций.</returns>
        public virtual BindingList<Operation> GetAllOperations()
        {
            return new BindingList<Operation>(_operationRepository.GetAll().ToList());
        }

        /// <summary>
        /// Получает операцию по ее идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор операции.</param>
        /// <returns>Операция с указанным идентификатором, или <c>null</c>, если операция не найдена.</returns>
        public virtual Operation GetOperationById(int id)
        {
            return _operationRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новую операцию.
        /// </summary>
        /// <param name="operation">Операция, которую нужно добавить.</param>
        /// <returns>Добавленная операция с обновленными данными.</returns>
        public virtual Operation AddOperation(Operation operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation), "Операция не может быть null.");
            }

            return _operationRepository.Add(operation);
        }

        /// <summary>
        /// Обновляет данные существующей операции.
        /// </summary>
        /// <param name="operation">Обновленные данные операции.</param>
        /// <returns>Обновленная операция.</returns>
        public virtual Operation UpdateOperation(Operation operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation), "Операция не может быть null.");
            }

            return _operationRepository.Update(operation);
        }

        /// <summary>
        /// Удаляет операцию.
        /// </summary>
        /// <param name="Id">Идентификатор операции, которую нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленной операции или <c>0</c>, если удаление не удалось.</returns>
        public virtual ulong DeleteOperation(int Id)
        {
            return _operationRepository.Delete(Id);
        }
    }
}