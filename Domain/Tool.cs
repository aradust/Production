using System;

namespace Production
{
    internal class Tools
    {
        private ToolType _Tt;
        private int _Id;
        private DateTime _DateReceived;
        private string _Status;
        private DateTime _DateTake;
        private string _Taker;

        public ToolType Tt
        {
            get { return _Tt; }
            set { _Tt = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public DateTime DateReceived
        {
            get { return _DateReceived; }
            set { _DateReceived = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public DateTime DateTake
        {
            get { return _DateTake; }
            set { _DateTake = value; }
        }
        public string Taker
        {
            get { return _Taker; }
            set { _Taker = value; }
        }
        public Tools(ToolType tt, int id, DateTime datereceived, string status, DateTime datetake, string taker)
        {
            _Tt = tt;
            _Id = id;
            _DateReceived = datereceived;
            _Status = status;
            _DateTake = datetake;
            _Taker = taker;
        }

    }
}