using System;

class Item
{
    string mName;
    int mGold;

    public Item(string Name, int Gold)
    {
        this.Name = Name;
        this.Gold = Gold;
    }

    public string Name
    {
        get{return mName;}
        set{mName = value;}
    }
    public int Gold
    {
        get{return mGold;}
        set{mGold = value;}
    }
}