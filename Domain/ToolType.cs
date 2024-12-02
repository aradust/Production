using System;

namespace Production
{
    internal class ToolType
    {
        private string _Name;
        private string _Description;

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
        public ToolType(string name, string description)
        {
            _Name = name;
            _Description = description;
        }
    }
}