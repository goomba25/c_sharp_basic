using System;

class Inven
{
    int SelectIndex = 0;

    public void InnerClassTest()
    {
        Inven_Slot NewInvenSlot = new Inven_Slot();
        NewInvenSlot.Select(this);
    }
    class Inven_Slot
    {
        int index;
        public void Select(Inven _inven)
        {
            _inven.SelectIndex = 100;
        }
    }
    int[] box;
    public enum INVEN_DIR
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
    void SelectMove()
    {

    }

    public Inven(int row, int col)
    {
        if(row < 1)
            row = 1;
        if(col < 1)
            col = 1;
        
        box = new int[row*col];
    }
}