using System;
using System.Collections.Generic;

namespace Production
{
    internal class WorkOrder;
    {
        private int _Id;
        private int _ProductId;
        private DateTime _Dateissued;
        private DateTime _DeadLine;
        private string _Quantity_Required;

    public int Id
    { 
        get { return _Id; }
        set { _Id = value; }
    }

    public int ProductId
    {
        get { return _ProductId;}
        set { _ProductId = value;}
    }
    public DateTime Dateissued
    {
        get { return _Dateissued;}
        set { Dateissued = value; }
    }
    public DateTime Dateissued
    {
        get { return _DeadLine; }
        set { _DeadLine = value; }
    }
    public string Quantity_Required
    {
        get { return _Quantity_Required; }
        set { _Quantity_Required = value; }
    }
    public Work_order(int id,int productid,DateTime dateissued, DateTime deadline, string quantity_required)
    {
        _Id = id;
        _Dateissued = dateissued;
        _Deadline = deadline;
        _Quantity_Required = quantity_required;
    }
}