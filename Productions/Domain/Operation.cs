using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace Production
{
    /// <summary>
    /// Класс, представляющий операцию с различными характеристиками, такими как идентификатор, название, описание и продолжительность.
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// Приватное поле для хранения уникального идентификатора операции.
        /// </summary>
        private int _Id;

        /// <summary>
        /// Приватное поле для хранения названия операции.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Приватное поле для хранения идентификатора цеха, в котором выполняется операция.
        /// </summary>
        private int _WorkShopId;

        /// <summary>
        /// Приватное поле для хранения идентификатора чертежа, на основании которого выполняется операция.
        /// </summary>
        private int _DrawingId;

        /// <summary>
        /// Приватное поле для хранения описания операции.
        /// </summary>
        private string _Description;

        /// <summary>
        /// Приватное поле для хранения средней продолжительности операции.
        /// </summary>
        private TimeSpan _AverageDuration;

        /// <summary>
        /// Приватное поле для хранения списка чертежей, связанных с операцией.
        /// </summary>
        private IList<Tools> _Tools = new List<Tools>();

        /// <summary>
        /// Уникальный идентификатор операции.
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Название операции.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Идентификатор цеха, в котором выполняется операция.
        /// </summary>
        public int WorkShopId
        {
            get { return _WorkShopId; }
            set { _WorkShopId = value; }
        }

        /// <summary>
        /// Идентификатор чертежа, на основании которого выполняется операция.
        /// </summary>
        public int DrawingId
        {
            get { return _DrawingId; }
            set { _DrawingId = value; }
        }

        /// <summary>
        /// Описание операции.
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        /// <summary>
        /// Средняя продолжительность операции.
        /// </summary>
        public TimeSpan AverageDuration
        {
            get { return _AverageDuration; }
            set { _AverageDuration = value; }
        }

        /// <summary>
        /// Список чертежей, связанных с операцией.
        /// </summary>
        public IList<Tools> Tools
        {
            get { return _Tools; }
            set { _Tools = value; }
        }

        /// <summary>
        /// Краткое описание операций в формате строки, содержащей названия всех чертежей.
        /// </summary>
        public string ToolsSummary
        {
            get { return (_Tools == null) ? "" : string.Join(", ", Tools.Select(t => t.Name)); }
        }

        /// <summary>
        /// Конструктор по умолчанию для создания объекта <see cref="Operation"/>.
        /// </summary>
        public Operation() { }

        /// <summary>
        /// Конструктор для создания нового объекта <see cref="Operation"/> с полным набором данных.
        /// </summary>
        /// <param name="id">Идентификатор операции.</param>
        /// <param name="name">Название операции.</param>
        /// <param name="workshopid">Идентификатор цеха, в котором выполняется операция.</param>
        /// <param name="drawingid">Идентификатор чертежа, на основании которого выполняется операция.</param>
        /// <param name="description">Описание операции.</param>
        /// <param name="averageduration">Средняя продолжительность операции.</param>
        public Operation(int id, string name, int workshopid, int drawingid, string description, TimeSpan averageduration)
        {
            _Id = id;
            _Name = name;
            _WorkShopId = workshopid;
            _DrawingId = drawingid;
            _Description = description;
            _AverageDuration = averageduration;
        }

        /// <summary>
        /// Конструктор для создания объекта <see cref="Operation"/> с минимальной информацией, только с названием.
        /// Используется для десериализации из JSON.
        /// </summary>
        /// <param name="name">Название операции.</param>
        [JsonConstructor]
        public Operation(string name)
        {
            _Name = name;
        }
    }
}
