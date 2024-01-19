using System;
using System.Collections.Generic;

public interface IKeyHolder
{
    string GetKey();
}

[Serializable]
public class ItemData : IKeyHolder
{
    public int KeyNumber;
    public string Name;
    public string Description;
    public int ItmeBaseType;
    
    public string GetKey()
    {
        return Name;
    }
}
