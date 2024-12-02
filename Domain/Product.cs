using System;
using System.Collections.Generic;

namespace Production
{
    /// <summary>
    /// Класс, представляющий продукт, который содержит информацию о его идентификаторе, названии, дате последнего производства, стоимости и операциях.
    /// </summary>
    
    public class Product
    {
        /// <summary>
        /// Приватное поле для хранения уникального идентификатора продукта.
        /// </summary>
        private int _Id;

        /// <summary>
        /// Приватное поле для хранения названия продукта.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Приватное поле для хранения даты последнего производства продукта.
        /// </summary>
        private DateTime _LastProductionDate;

        /// <summary>
        /// Приватное поле для хранения стоимости продукта.
        /// </summary>
        private int _Cost;
        private IList<Operation> _Operations;

        /// <summary>
        /// Приватное поле, содержащее список операций, связанных с производством продукта.
        /// </summary>
        

        /// <summary>
        /// Свойство для получения идентификатора продукта.
        /// </summary>
        /// <value>Возвращает уникальный идентификатор продукта.</value>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Свойство для получения или установки названия продукта.
        /// </summary>
        /// <value>Возвращает или устанавливает название продукта.</value>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Свойство для получения или установки даты последнего производства продукта.
        /// </summary>
        /// <value>Возвращает или устанавливает дату последнего производства продукта.</value>
        public DateTime LastProductionDate
        {
            get { return _LastProductionDate; }
            set { _LastProductionDate = value; }
        }

        /// <summary>
        /// Свойство для получения или установки стоимости продукта.
        /// </summary>
        /// <value>Возвращает или устанавливает стоимость продукта.</value>
        public int Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        /// <summary>
        /// Свойство для получения списка операций, связанных с продуктом.
        /// </summary>
        /// <value>Возвращает список операций с продуктом.</value>
        public IList<Operation> Operations
        {
            get { return _Operations; }
            set { _Operations = value; }
        }

        /// <summary>
        /// Конструктор класса <see cref="Product"/>.
        /// Инициализирует новый объект продукта с заданными значениями.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <param name="name">Название продукта.</param>
        /// <param name="lastProductionDate">Дата последнего производства.</param>
        /// <param name="cost">Стоимость продукта.</param>
        public Product(int id, string name, DateTime lastProductionDate, int cost)
        {
            _Id = id;
            _Name = name;
            _LastProductionDate = lastProductionDate;
            _Cost = cost;
            _Operations = new List<Operation>();  // Инициализация списка операций
        }
    }
}
