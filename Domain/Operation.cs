using System;
using System.Collections.Generic;
namespace Production
{
    public class Operation
    {
        private int _Id;
        private string _Name;
        private int _WorkShopId;
        private int _DrawingId;
        private string _Description;
        //private TimeSpan _AverageDuration;
        private int _DrawingNumber;

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
        public int WorkShopId
        {
            get { return _WorkShopId; }
            set { _WorkShopId = value; }
        }
        public int DrawingId
        {
            get { return _DrawingId; }
            set
            {
                _DrawingId = value;
            }

        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        /* public TimeSpan AverageDuration
         {
             get { return _AverageDuration ; }
             set
             {
                 _AverageDuration = value;
             }
         }*/
        public int DrawingNumber
        {
            get { return _DrawingNumber; }
            set
            {
                _DrawingNumber = value;
            }
        }
        public Operation(int id, string name, int workshopid, int drawingid, string description,/*TimeSpan averageduration*/ int drawingnumber)
        {
            _Id = id;
            _Name = name;
            _WorkShopId = workshopid;
            _DrawingId = drawingid;
            _Description = description;
            /* _AverageDuration = averageduration;*/
            _DrawingNumber = drawingnumber;
            // Инициализация списка операций
        }
        //private List<Material> Materials;
        //private List<Tool> Tools;
    }
}
