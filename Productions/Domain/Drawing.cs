using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Production
{
    /// <summary>
    /// Представляет информацию о чертеже.
    /// </summary>
    public class Drawing
    {
        /// <summary>
        /// Приватное поле для хранения уникального идентификатора чертежа.
        /// </summary>
        private int _Id;

        /// <summary>
        /// Приватное поле для хранения названия чертежа.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Приватное поле для хранения описания чертежа.
        /// </summary>
        private string _Description;

        /// <summary>
        /// Приватное поле для хранения технических характеристик чертежа.
        /// </summary>
        private string _Specifications;

        /// <summary>
        /// Уникальный идентификатор чертежа.
        /// </summary>
        /// <value>Целое число, представляющее уникальный идентификатор.</value>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Название чертежа.
        /// </summary>
        /// <value>Строка, представляющая название.</value>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Описание чертежа.
        /// </summary>
        /// <value>Строка, содержащая описание чертежа.</value>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        /// <summary>
        /// Технические характеристики чертежа.
        /// </summary>
        /// <value>Строка, содержащая технические характеристики.</value>
        public string Specifications
        {
            get { return _Specifications; }
            set { _Specifications = value; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Drawing"/> с заданными параметрами.
        /// </summary>
        /// <param name="id">Уникальный идентификатор чертежа.</param>
        /// <param name="name">Название чертежа.</param>
        /// <param name="description">Описание чертежа.</param>
        /// <param name="specifications">Технические характеристики чертежа.</param>
        public Drawing(int id, string name, string description, string specifications)
        {
            _Id = id;
            _Name = name;
            _Description = description;
            _Specifications = specifications;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Drawing"/> с заданным названием.
        /// Используется для десериализации из JSON.
        /// </summary>
        /// <param name="name">Название чертежа.</param>
        [JsonConstructor]
        public Drawing(string name)
        {
            _Name = name;
        }
    }
}
