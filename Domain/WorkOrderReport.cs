using System.Collections.Generic;
using System;

namespace Production
{
    internal class WorkOrderReport
    {
        private int _WorkOrderId;
        private int _ProductId;
        private string _Name;
        private DateTime _Dateissued;
        private DateTime _CompletionDate;
        private int _QuantityProduced;
        private int _OperationPerfomed;

        public int WorkOrderId
        {
            get { return _WorkOrderId; }
            set { _WorkOrderId = value; }
        }
        public int ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public DateTime Dateissued
        {
            get { return _Dateissued; }
            set { Dateissued = value; }
        }
        public DateTime CompletionDate
        {
            get { return _CompletionDate; }
            set { _CompletionDate = value; }
        }
        public int QuantityProduced
        {
            get { return _QuantityProduced; }
            set { _QuantityProduced = value; }
        }
        public int OperationPerfomed
        {
            get { return _OperationPerfomed; }
            set { _OperationPerfomed = value; }
        }
        public WorkOrderReport(int workorderid, int productid, string name, DateType dateissued, DateType completiondate, int quantityproduced, int operationperfomed)
        {
            _WorkOrderId = workorderid;
            _ProductId = productid;
            _Name = name;
            _Dateissued = dateissued;
            _CompletionDate = completiondate;
            _QuantityProduced = quantityproduced;
            _OperationPerfomed = operationperfomed;
        }
    }
}
    


