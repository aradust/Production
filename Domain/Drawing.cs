using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
namespace Production
{
    public class Drawing
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
        private string _Description;

        /// <summary>
        /// Приватное поле для хранения стоимости продукта.
        /// </summary>
        private string _Specifications;
        


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
       public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        /// <summary>
        /// Свойство для получения или установки стоимости продукта.
        /// </summary>
        /// <value>Возвращает или устанавливает стоимость продукта.</value>
        public string Specifications
        {
            get { return _Specifications; }
            set { _Specifications = value; }
        }

       
        public Drawing(int id, string name, string description, string specifications )
        {
            _Id = id;
            _Name = name;
            _Description = description;
            _Specifications = specifications;
        }


        [JsonConstructor]
        public Drawing(string name)
        {
            _Name = name;
        }
       
    }
}
