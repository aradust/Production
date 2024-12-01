using System;

namespace Production
{
    internal class Material
    {
        private int _Id;
        private string _Name;
        private string _Description;

 public int Id
 {
        get { return _Id;}
        set { _Id = value;}
 }

public string Name
{
    get { return _Name;}
    set { _Name = value;}
}

public string Description
{
    get { return _Description;}
    set { _Description = value;}
}

public Material(int id, string name, string description)
{
    _Id = id;
    _Name = name;
    _Description = description;
}
     }
}