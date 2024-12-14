using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Production
{
    /// <summary>
    /// Класс, представляющий продукт, который содержит информацию о его идентификаторе, названии, дате последнего производства, стоимости и связанных операциях.
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

        /// <summary>
        /// Приватное поле для хранения списка операций, связанных с продуктом.
        /// </summary>
        private IList<Operation> _Operations = new List<Operation>();

        /// <summary>
        /// Уникальный идентификатор продукта.
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Название продукта.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
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

        /// <summary>
        /// Список операций, связанных с производством продукта.
        /// </summary>
        public IList<Operation> Operations
        {
            get { return _Operations; }
            set { _Operations = value; }
        }

        /// <summary>
        /// Краткое описание операций, связанных с продуктом, в виде строки, содержащей названия операций.
        /// </summary>
        public string OperationsSummary
        {
            get { return (_Operations == null) ? "" : string.Join(", ", Operations.Select(op => op.Name)); }
        }

        /// <summary>
        /// Конструктор для создания нового объекта <see cref="Product"/> с заданными данными.
        /// </summary>
        /// <param name="id">Уникальный идентификатор продукта.</param>
        /// <param name="name">Название продукта.</param>
        /// <param name="lastProductionDate">Дата последнего производства продукта.</param>
        /// <param name="cost">Стоимость продукта.</param>
        public Product(int id, string name, DateTime lastProductionDate, int cost)
        {
            _Id = id;
            _Name = name;
            _LastProductionDate = lastProductionDate;
            _Cost = cost;
        }

        /// <summary>
        /// Конструктор для создания объекта <see cref="Product"/> с минимальной информацией (только названием).
        /// Используется для десериализации из JSON.
        /// </summary>
        /// <param name="name">Название продукта.</param>
        [JsonConstructor]
        public Product(string name)
        {
            _Name = name;
        }

        /// <summary>
        /// Конструктор для создания объекта <see cref="Product"/> с указанием только стоимости.
        /// </summary>
        /// <param name="cost">Стоимость продукта.</param>
        public Product(int cost)
        {
            _Cost = cost;
        }
    }
}
