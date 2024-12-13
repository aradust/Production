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
        private int _Id;
        private string _Name;
        private int _WorkShopId;
        private int _DrawingId;
        private string _Description;
        private TimeSpan _AverageDuration;
        private IList<Drawing> _Drawings = new List<Drawing>();
        /// <summary>
        /// Идентификатор операции.
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
        /// Номер чертежа, на котором выполняется операция.
        /// </summary>
        public IList<Drawing> Drawings
        {
            get { return _Drawings; }
            set { _Drawings = value; }
        }
        public string OperationsSummary
        {
            get { return (_Drawings == null) ? "" : string.Join(", ", Drawings.Select(op => op.Name)); }
        }
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
        /// <param name="drawingnumber">Номер чертежа, на котором выполняется операция.</param>
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
        /// </summary>
        /// <param name="name">Название операции.</param>
        [JsonConstructor]
        public Operation(string name)
        {
            _Name = name;
        }
    }
}
