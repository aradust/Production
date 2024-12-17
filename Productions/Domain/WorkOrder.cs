using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Production
{
    /// <summary>
    /// Класс, представляющий наряд на производство, содержащий информацию о продукте, дате выпуска, сроке исполнения и требуемом количестве.
    /// </summary>
    public class WorkOrder
    {
        /// <summary>
        /// Уникальный идентификатор наряда.
        /// </summary>
        private int _Id;

        /// <summary>
        /// Уникальный идентификатор продукта, связанного с нарядом.
        /// </summary>
        private int _ProductId;

        /// <summary>
        /// Дата выпуска наряда.
        /// </summary>
        private DateTime _DateIssued;

        /// <summary>
        /// Крайний срок выполнения наряда.
        /// </summary>
        private DateTime _DeadLine;

        /// <summary>
        /// Требуемое количество продукции по наряду.
        /// </summary>
        private int _QuantityRequired;

        /// <summary>
        /// Список продуктов, связанных с нарядом.
        /// </summary>
        private IList<Product> _Products = new List<Product>();

        /// <summary>
        /// Уникальный идентификатор наряда.
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Уникальный идентификатор продукта, связанного с нарядом.
        /// </summary>
        public int ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }

        /// <summary>
        /// Дата выпуска наряда.
        /// </summary>
        public DateTime DateIssued
        {
            get { return _DateIssued; }
            set { _DateIssued = value; }
        }

        /// <summary>
        /// Крайний срок выполнения наряда.
        /// </summary>
        public DateTime DeadLine
        {
            get { return _DeadLine; }
            set { _DeadLine = value; }
        }

        /// <summary>
        /// Требуемое количество продукции по наряду.
        /// </summary>
        public int QuantityRequired
        {
            get { return _QuantityRequired; }
            set { _QuantityRequired = value; }
        }

        /// <summary>
        /// Список продуктов, связанных с нарядом.
        /// </summary>
        public IList<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }

        /// <summary>
        /// Конструктор класса <see cref="WorkOrder"/>, инициализирующий все основные свойства.
        /// </summary>
        /// <param name="id">Уникальный идентификатор наряда.</param>
        /// <param name="productid">Уникальный идентификатор продукта, связанного с нарядом.</param>
        /// <param name="dateissued">Дата выпуска наряда.</param>
        /// <param name="deadline">Крайний срок выполнения наряда.</param>
        /// <param name="quantityrequired">Требуемое количество продукции по наряду.</param>
        public WorkOrder(int id, int productid, DateTime dateissued, DateTime deadline, int quantityrequired)
        {
            _Id = id;
            _ProductId = productid;
            _DateIssued = dateissued;
            _DeadLine = deadline;
            _QuantityRequired = quantityrequired;
        }

        /// <summary>
        /// Конструктор по умолчанию для класса <see cref="WorkOrder"/>, используемый для десериализации или создания пустого наряда.
        /// </summary>
        [JsonConstructor]
        public WorkOrder()
        {
        }
    }
}
