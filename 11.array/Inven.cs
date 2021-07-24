using System;

class Inven
{
    Item[] Inventory;
    int SelectIndex = 0;
    int row;
    int col;

    public Inven(int row, int col)  // 생성자
    {
        //방어코드(switch문의 default 등...) 필수
        if(row < 1)
            row = 1;
        if(col < 1)
            col = 1;

        this.row = row;
        this.col = col;

        Inventory = new Item[(row*col)];
    }

    public void Render()
    {
        for(int i = 0; i < Inventory.Length; i++)
        {
            if(SelectIndex == i)
            {
                Console.Write("▣");
            }

            if(0 != i && 0 == i%row)
            {
                Console.WriteLine("");
            }

            if(null == Inventory[i])
            {
                Console.Write("□ ");
            }
            else
            {
                Console.Write("■ ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("현재 선택한 아이템");
        Console.WriteLine("이름 : " + Inventory[SelectIndex].Name);
        Console.WriteLine("가격 : " + Inventory[SelectIndex].Gold);
    }

    public void ItemIn(Item _item)
    {
        int index = 0;

        for(int i = 0; i < Inventory.Length; i++)
        {
            if(null == Inventory[i])
            {
                index = i;
                Inventory[index] = _item;
                break;
            }
        }
    }

    public void ItemIn(Item _item, int _order)    //  오버로딩
    {
        if(null != Inventory[_order])
        {
            return;
        }

        if(_order > (row*col))
        {
            return;
        }

        Inventory[(_order-1)] = _item;
    }
}