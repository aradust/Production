using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
namespace Production
{
    public class WorkOrder
    { 
        private int _Id;
        private int _ProductId;
        private DateTime _DateIssued;
        private DateTime _DeadLine;
        private int _QuantityRequired;
        private IList<Product> _Products = new List<Product>();
        


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }

        }
        public DateTime DateIssued
        {
            get { return _DateIssued; }
            set { _DateIssued = value; }
        }
        public DateTime DeadLine
        {
            get { return _DeadLine; }
            set { _DeadLine = value; }
        }
        public int QuantityRequired
        {
            get { return _QuantityRequired; }
            set { _QuantityRequired = value; }
        }

        public IList<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }

        



        public WorkOrder(int id,int productid,DateTime dateissued, DateTime deadline,int quantityrequired)
        {
            _Id = id;
            _ProductId = productid;
            _DateIssued = dateissued;
            _DeadLine = deadline;
            _QuantityRequired=quantityrequired;
        }


        [JsonConstructor]
        
        public WorkOrder()
        {

        }
    }
}
