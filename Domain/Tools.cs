using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json;
namespace Production
{
    /// <summary>
    /// Класс, представляющий тип инструмента, содержащий информацию о его названии и описании.
    /// </summary>
    public class Tools
    {
        private int _Id;

        /// <summary>
        /// Название типа инструмента.
        /// </summary>
        /// 
        private int _TypeId;
        private List <int> _InstanceId;

        private string _Name;
        private DateTime _Date;
        /// <summary>
        /// Описание типа инструмента.
        /// </summary>
        private string _Description;
        private int _QuantityTake;
        private int _QuantityStay;

        public int Id { get { return _Id; } set { _Id = value; } }
        /// <summary>
        /// Получает или задает название типа инструмента.
        /// </summary>
        /// 
        public int TypeId
        {
            get { return _TypeId; }
            set { _TypeId = value; }
        }
        public List<int> InstanceId
        {
            get { return _InstanceId; }
            set { _InstanceId = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        /// <summary>
        /// Получает или задает описание типа инструмента.
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public int QuantityTake
        {
            get { return _QuantityTake; }
            set { _QuantityTake = value; }
        }
        public int QuantityStay
        {
            get { return _QuantityStay; }
            set { _QuantityStay = value; }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="ToolType"/>.
        /// </summary>
        /// <param name="name">Название типа инструмента.</param>
        /// <param name="description">Описание типа инструмента.</param>
        public Tools(string name, string description,int typeid,DateTime date, int quantitytake, int quantitystay, List<int> instanceid)
        {
            _Name = name;
            _Description = description;
            _TypeId = typeid;
            _InstanceId = instanceid;
            _Date = date;
            _QuantityTake = quantitytake;
            _QuantityStay = quantitystay;
            
        }
        [JsonConstructor]
        public Tools(string name)
        {
            _Name = name;
        }
    }
   
}


        
     
        