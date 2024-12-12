using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
namespace Production
{
    public class WorkShop
    {
        private string _Name; //имя цеха
        private int _Id; //номер цеха 


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

        public WorkShop(string name, int id)
        {
            _Name = name;
            _Id = id;
        }

        [JsonConstructor]
        public WorkShop(string name)
        {
            _Name = name;
        }

    }
    } 
