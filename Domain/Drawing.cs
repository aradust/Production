    using System;
    using System.Collections.Generic;
    namespace Production
{
    internal class Drawing
    {
        private int _Id;
        private string _Name; 
        private string _Description;
        private string _Specification;

        public int Id
        {
            get { return _Id; }
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
        public string Specification
        {
            get { return _Specification; }
            set { _Specification = value; }
        }
        
        public Drawing(int id, string name, string description, string specification)
        {
            _Id = id;
            _Name = name;
            _Description = description;
            _Specification = specification;
        }

    }
}