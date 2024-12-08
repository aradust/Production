using System;

namespace Production
{
    /// <summary>
    /// Класс, представляющий тип инструмента, содержащий информацию о его названии и описании.
    /// </summary>
    public class ToolType
    {
        /// <summary>
        /// Название типа инструмента.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Описание типа инструмента.
        /// </summary>
        private string _Description;

        /// <summary>
        /// Получает или задает название типа инструмента.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        /// Получает или задает описание типа инструмента.
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="ToolType"/>.
        /// </summary>
        /// <param name="name">Название типа инструмента.</param>
        /// <param name="description">Описание типа инструмента.</param>
        public ToolType(string name, string description)
        {
            _Name = name;
            _Description = description;
        }
    }
}
