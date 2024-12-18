using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Production
{
    /// <summary>
    /// Класс, представляющий цех на производстве с информацией о его названии и уникальном идентификаторе.
    /// </summary>
    public class WorkShop
    {
        /// <summary>
        /// Название цеха.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Уникальный номер (идентификатор) цеха.
        /// </summary>
        private int _Id;

        /// <summary>
        /// Свойство для получения или установки названия цеха.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Свойство для получения или установки уникального номера (идентификатора) цеха.
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public WorkShop() { }
        /// <summary>
        /// Конструктор класса <see cref="WorkShop"/>, инициализирующий объект с названием и идентификатором цеха.
        /// </summary>
        /// <param name="name">Название цеха.</param>
        /// <param name="id">Уникальный номер (идентификатор) цеха.</param>
        public WorkShop(string name, int id)
        {
            _Name = name;
            _Id = id;
        }

        /// <summary>
        /// Конструктор класса <see cref="WorkShop"/>, принимающий только название цеха.
        /// Используется, например, для десериализации.
        /// </summary>
        /// <param name="name">Название цеха.</param>
        [JsonConstructor]
        public WorkShop(string name)
        {
            _Name = name;
        }
    }
}
