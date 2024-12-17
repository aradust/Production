using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    /// <summary>
    /// Класс, представляющий тип инструмента, содержащий информацию о его идентификаторе, названии и описании.
    /// </summary>
    public class ToolType
    {
        /// <summary>
        /// Уникальный идентификатор типа инструмента.
        /// </summary>
        private int _Id;

        /// <summary>
        /// Название типа инструмента.
        /// </summary>
        private string _Name;

        /// <summary>
        /// Описание типа инструмента.
        /// </summary>
        private string _Description;

        /// <summary>
        /// Получает или задает уникальный идентификатор типа инструмента.
        /// </summary>
        public int Id { get { return _Id; } set { _Id = value; } }

        /// <summary>
        /// Получает или задает название типа инструмента.
        /// </summary>
        public string Name { get { return _Name; } set { _Name = value; } }

        /// <summary>
        /// Получает или задает описание типа инструмента.
        /// </summary>
        public string Description { get { return _Description; } set { _Description = value; } }
    }
}
