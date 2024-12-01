using System;

namespace Production
{
    internal class ThisWorkShop
    {
        private string _Name;
        private int _Id;
        
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }

        }
        public ThisWorkShop(string name,int id)
        {
            _Name = name;
            _Id = id;
        }
    }
}