using System;
using Newtonsoft.Json;

namespace Production
{
    /// <summary>
    /// Класс, представляющий продукт.
    /// Содержит информацию об идентификаторе, имени, дате последнего производства и стоимости.
    /// </summary>
    public class Product
    {
        // Приватные поля
        private int _id;
        private string _name;
        private DateTime _LastProductionDate;
        private int _Cost;

        // Свойства

        /// <summary>
        /// Идентификатор продукта.
        /// Уникальный номер, присваиваемый каждому продукту.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Название продукта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Дата последнего производства продукта.
        /// </summary>
        public DateTime LastProductionDate
        {
            get { return _LastProductionDate; }
            set { _LastProductionDate = value; }
        }

        /// <summary>
        /// Стоимость продукта.
        /// </summary>
        public int Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        // Конструкторы

        /// <summary>
        /// Конструктор класса <see cref="Product"/>, принимающий все параметры.
        /// Используется для полной инициализации продукта.
        /// </summary>
        /// <param name="id">Идентификатор продукта.</param>
        /// <param name="name">Название продукта.</param>
        /// <param name="lastproductiondate">Дата последнего производства продукта.</param>
        /// <param name="cost">Стоимость продукта.</param>
        [JsonConstructor]
        public Product(int id, string name, DateTime lastproductiondate, int cost)
        {
            _id = id;
            _name = name;
            _LastProductionDate = lastproductiondate;
            _Cost = cost;
        }

        /// <summary>
        /// Конструктор класса <see cref="Product"/>, принимающий только название продукта.
        /// Используется для быстрого создания продукта с минимальной информацией.
        /// </summary>
        /// <param name="name">Название продукта.</param>
        public Product(string name)
        {
            _name = name;
        }
    }
}
