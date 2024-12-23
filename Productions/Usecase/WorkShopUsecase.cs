﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Production
{
    /// <summary>
    /// Класс, реализующий бизнес-логику для работы с цехами.
    /// Использует репозиторий <see cref="IWorkShopRepository"/> для выполнения операций с цехами.
    /// </summary>
    public class WorkShopUsecase
    {
        protected readonly IWorkShopRepository _workShopRepository;

        /// <summary>
        /// Конструктор класса <see cref="WorkShopUsecase"/>.
        /// </summary>
        /// <param name="workShopRepository">Репозиторий для работы с цехами.</param>
        public WorkShopUsecase(IWorkShopRepository workShopRepository)
        {
            _workShopRepository = workShopRepository ?? throw new ArgumentNullException(nameof(workShopRepository), "Репозиторий не может быть null.");
        }

        /// <summary>
        /// Получает все цехи.
        /// </summary>
        /// <returns>Список всех цехов.</returns>
        public virtual BindingList<WorkShop> GetAllWorkShop()
        {
            return new BindingList<WorkShop>(_workShopRepository.GetAll().ToList());
        }

        /// <summary>
        /// Получает цех по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор цеха.</param>
        /// <returns>Цех с указанным идентификатором, или <c>null</c>, если цех не найден.</returns>
        public virtual WorkShop GetWorkShopById(int id)
        {
            return _workShopRepository.GetByID(id);
        }

        /// <summary>
        /// Добавляет новый цех.
        /// </summary>
        /// <param name="workShop">Цех, который нужно добавить.</param>
        /// <returns>Добавленный цех с обновленными данными.</returns>
        public virtual WorkShop AddWorkShop(WorkShop workShop)
        {
            if (workShop == null)
            {
                throw new ArgumentNullException(nameof(workShop), "Цех не может быть null.");
            }

            return _workShopRepository.Add(workShop);
        }

        /// <summary>
        /// Обновляет данные существующего цеха.
        /// </summary>
        /// <param name="workShop">Обновленные данные цеха.</param>
        /// <returns>Обновленный цех.</returns>
        public virtual WorkShop UpdateWorkShop(WorkShop workShop)
        {
            if (workShop == null)
            {
                throw new ArgumentNullException(nameof(workShop), "Цех не может быть null.");
            }

            return _workShopRepository.Update(workShop);
        }

        /// <summary>
        /// Удаляет цех.
        /// </summary>
        /// <param name="Id">Идентификатор цеха, который нужно удалить.</param>
        /// <returns>Возвращает уникальный идентификатор удаленного цеха или <c>0</c>, если удаление не удалось.</returns>
        public virtual ulong DeleteWorkShop(int Id)
        {
            /* if (Id == null)
             {
                 //throw new ArgumentNullException(nameof(WorkShop workShop.Id), "Цех не может быть null.");
             }*/

            return _workShopRepository.Delete(Id);
        }
    }
}
