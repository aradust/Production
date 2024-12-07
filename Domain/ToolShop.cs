using System.Collections.Generic;
using System;

namespace Production
{
    internal class ToolShop
    {
        private int _Id;
        private string _Name;
        private string _Description;
        private IList<Tool> _Tools;
        //public GetAll();
        //public Reserve();
        //public GetAvailable();
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public IList<Tool> Tools
        {
            get { return _Tools; }
            set { _Tools = value; }
        }
        public ToolShop(int id, string name, string description)
        {
            _Id = id;
            _Name = name;
            _Description = description;
            _Tools = new List<Tools>();
        }

    }
}
