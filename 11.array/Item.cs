using System;

class Item
{
    string mName;
    int mGold;

    public Item(string Name, int Gold)
    {
        this.mName = Name;
        this.mGold = Gold;
    }

        public string Name
    {
        get
        {
            return mName;
        }

        set
        {
            mName = value;
        }
    }
    public int Gold
    {
        get
        {
            return mGold;
        }

        set
        {
            mGold = value;
        }
    }
}