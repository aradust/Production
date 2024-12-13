using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json;
namespace Production
{
    /// <summary>
    /// Класс, представляющий инструменты с информацией о типе, экземплярах, дате, количестве и описании.
    /// </summary>
    public class Tools
    {
        /// <summary>
        /// Уникальный идентификатор типа инструмента.
        /// </summary>
        private int _TypeId;

        /// <summary>
        /// Список идентификаторов экземпляров инструмента.
        /// </summary>
        private List<int> _InstanceId;

        /// <summary>
        /// Название инструмента.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Дата, связанная с инструментом (например, дата выдачи).
        /// </summary>
        private DateTime _Date;

        /// <summary>
        /// Описание инструмента.
        /// </summary>
        private string _Description;

        /// <summary>
        /// Количество инструментов, которые были выданы.
        /// </summary>
        private int _QuantityTake;

        /// <summary>
        /// Количество инструментов, которые остаются в наличии.
        /// </summary>
        private int _QuantityStay;

        /// <summary>
        /// Получает или задает уникальный идентификатор типа инструмента.
        /// </summary>
        public int TypeId
        {
            get { return _TypeId; }
            set { _TypeId = value; }
        }

        /// <summary>
        /// Получает или задает список идентификаторов экземпляров инструмента.
        /// </summary>
        public List<int> InstanceId
        {
            get { return _InstanceId; }
            set { _InstanceId = value; }
        }

        /// <summary>
        /// Получает или задает название инструмента.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Получает или задает дату, связанную с инструментом.
        /// </summary>
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        /// <summary>
        /// Получает или задает описание инструмента.
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        /// <summary>
        /// Получает или задает количество инструментов, которые были выданы.
        /// </summary>
        public int QuantityTake
        {
            get { return _QuantityTake; }
            set { _QuantityTake = value; }
        }

        /// <summary>
        /// Получает или задает количество инструментов, которые остаются в наличии.
        /// </summary>
        public int QuantityStay
        {
            get { return _QuantityStay; }
            set { _QuantityStay = value; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tools"/> с полной информацией.
        /// </summary>
        /// <param name="name">Название инструмента.</param>
        /// <param name="description">Описание инструмента.</param>
        /// <param name="typeid">Идентификатор типа инструмента.</param>
        /// <param name="date">Дата поступления инструмента на склад.</param>
        /// <param name="quantitytake">Количество инструментов, которые были выданы.</param>
        /// <param name="quantitystay">Количество инструментов, которые остаются в наличии.</param>
        /// <param name="instanceid">Список идентификаторов экземпляров инструмента.</param>
        public Tools(string name, string description, int typeid, DateTime date, int quantitytake, int quantitystay, List<int> instanceid)
        {
            _Name = name;
            _Description = description;
            _TypeId = typeid;
            _InstanceId = instanceid;
            _Date = date;
            _QuantityTake = quantitytake;
            _QuantityStay = quantitystay;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tools"/> с минимальной информацией, используя только название.
        /// </summary>
        /// <param name="name">Название инструмента.</param>
        [JsonConstructor]
        public Tools(string name)
        {
            _Name = name;
        }
    }
}
