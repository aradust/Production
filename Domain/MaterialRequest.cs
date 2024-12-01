using System;
using System.Collections.Generic;
namespace Production
{
    internal class MaterialRequest
    {
        private int _WorkOrderId;
        private int _Quantity;
        private string _Material;
        private DateTime _ReserveDate;

        public int WorkOrder
        {
            get { return _WorkOrderId; }
            set { _WorkOrderId = value; }


        }


        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }


        public string Material
        {
            get { return _Material; }
            set { _Material = value; }


        }

        public DateTime ReserveDate
        {
            get { return _ReserveDate; }
            set { _ReserveDate = value; }
        }

        public MaterialRequest(int workorderid, int quantity, string material, DateTime reservedate)
        {
            _WorkOrderId = workorderid;
            _Quantity = quantity;
            _Material = material
            _ReserveDate = reservedate;
        }
    } 
}
