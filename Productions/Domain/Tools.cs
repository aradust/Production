using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Production
{
    /// <summary>
    /// Класс, представляющий инструменты с подробной информацией, включая тип, идентификаторы экземпляров, дату, описание и количество.
    /// </summary>
    public class Tools
    {
        /// <summary>
        /// Уникальный идентификатор инструмента.
        /// </summary>
        private int _Id;

        /// <summary>
        /// Уникальный идентификатор типа инструмента.
        /// </summary>
        private int _TypeId;

        /// <summary>
        /// Название инструмента.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Дата, связанная с инструментом (например, дата поступления или выдачи).
        /// </summary>
        private DateTime _Date;

        /// <summary>
        /// Описание инструмента.
        /// </summary>
        private string _Description;

        /// <summary>
        /// Уникальный идентификатор инструмента.
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Уникальный идентификатор типа инструмента.
        /// </summary>
        public int TypeId
        {
            get { return _TypeId; }
            set { _TypeId = value; }
        }

        /// <summary>
        /// Название инструмента.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Дата, связанная с инструментом.
        /// </summary>
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        /// <summary>
        /// Описание инструмента.
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }


        /// <summary>
        /// Конструктор для создания нового объекта <see cref="Tools"/> с полной информацией.
        /// </summary>
        /// <param name="name">Название инструмента.</param>
        /// <param name="description">Описание инструмента.</param>
        /// <param name="typeid">Идентификатор типа инструмента.</param>
        /// <param name="date">Дата, связанная с инструментом.</param>
        /// <param name="quantitytake">Количество инструментов, которые были выданы.</param>
        /// <param name="quantitystay">Количество инструментов, которые остаются в наличии.</param>
        /// <param name="instanceid">Список идентификаторов экземпляров инструмента.</param>
        public Tools(string name, string description, int typeid, DateTime date)
        {
            _Name = name;
            _Description = description;
            _TypeId = typeid;
            _Date = date;
        }

        /// <summary>
        /// Конструктор для создания нового объекта <see cref="Tools"/> с минимальной информацией.
        /// </summary>
        /// <param name="name">Название инструмента.</param>
        [JsonConstructor]
        public Tools(string name)
        {
            _Name = name;
        }
    }
}
