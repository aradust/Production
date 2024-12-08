using System;
using Newtonsoft.Json;

namespace Production
{
    /// <summary>
    /// Класс, представляющий инструмент с подробной информацией о его типе, состоянии и пользователе.
    /// </summary>
    public class Tools
    {
        private string _Name;
        private ToolType _Tt;
        private int _Id;
        private DateTime _DateReceived;
        private string _Status;
        private DateTime _DateTake;
        private string _Taker;

        /// <summary>
        /// Название инструмента.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Тип инструмента, представленный экземпляром класса <see cref="ToolType"/>.
        /// </summary>
        public ToolType Tt
        {
            get { return _Tt; }
            set { _Tt = value; }
        }

        /// <summary>
        /// Уникальный идентификатор инструмента.
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Дата получения инструмента.
        /// </summary>
        public DateTime DateReceived
        {
            get { return _DateReceived; }
            set { _DateReceived = value; }
        }

        /// <summary>
        /// Статус инструмента (например, "доступен", "в эксплуатации").
        /// </summary>
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        /// <summary>
        /// Дата, когда инструмент был взят.
        /// </summary>
        public DateTime DateTake
        {
            get { return _DateTake; }
            set { _DateTake = value; }
        }

        /// <summary>
        /// Имя человека, взявшего инструмент.
        /// </summary>
        public string Taker
        {
            get { return _Taker; }
            set { _Taker = value; }
        }

        /// <summary>
        /// Конструктор для создания экземпляра инструмента с полными данными.
        /// </summary>
        /// <param name="tt">Тип инструмента.</param>
        /// <param name="id">Идентификатор инструмента.</param>
        /// <param name="datereceived">Дата получения инструмента.</param>
        /// <param name="status">Статус инструмента.</param>
        /// <param name="datetake">Дата взятия инструмента.</param>
        /// <param name="taker">Имя того, кто взял инструмент.</param>
        public Tools(ToolType tt, int id, DateTime datereceived, string status, DateTime datetake, string taker)
        {
            _Tt = tt;
            _Id = id;
            _DateReceived = datereceived;
            _Status = status;
            _DateTake = datetake;
            _Taker = taker;
        }

        /// <summary>
        /// Конструктор для создания экземпляра инструмента только с названием.
        /// </summary>
        /// <param name="name">Название инструмента.</param>
        [JsonConstructor]
        public Tools(string name)
        {
            _Name = name;
        }
    }
}
