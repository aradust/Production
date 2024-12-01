using System;
using System.Collections.Generic;
namespace Production
{
    internal class Operation
    {
        private int _Id;
        private string _Name;
        private int _WorkShopId;
        private int _DrawingId;
        private string _Description;
        private TimeSpan _AverageDuration;
        private int _DrawingNumber;

        public int Id
        {
            get { return _Id; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int WorkShopId
        {
            get { return _WorkShopId; }
        }
        public int DrawingId
        {
            get { return _DrawingId; }

        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public TimeSpan AverageDuration
        {
            get { return _AverageDuration ; }
        }
        public int DrawingNumber
        {
            get { return _DrawingNumber; }
        }
        //private List<Material> Materials;
        //private List<Tool> Tools;
    }
}
