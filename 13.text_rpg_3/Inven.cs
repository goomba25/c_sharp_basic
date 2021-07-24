using System;

class Inven
{
    Item[] Inventory;
    int SelectIndex = 0;
    int row;

    public Inven(int row, int col)
    {
        if (row < 1)
            row = 1;
        if (col < 1)
            col = 1;

        this.row = row;

        Inventory = new Item[row * col];
    }

    public bool OverCheck(int _SelectIndex)
    {
        return false;
    }

    public void SelectMove()
    {
        if(true == OverCheck(SelectIndex))
        {
            return;
        }
    }

    public void SelectMoveLeft()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= 1;

        if(true == OverCheck(CheckIndex))
        {
            return;
        }

        SelectIndex -= 1;
    }

    public void SelectMoveRight()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += 1;

        if(true == OverCheck(CheckIndex))
        {
            return;
        }

        SelectIndex += 1;
    }

    public void SelectMoveUp()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= row;

        if(true == OverCheck(CheckIndex))
        {
            return;
        }

        SelectIndex -= row;
    }

    public void SelectMoveDown()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += row;

        if(true == OverCheck(CheckIndex))
        {
            return;
        }

        SelectIndex += row;
    }


    public void Render()
    {
        for (int i = 0; i < Inventory.Length; i++)
        {
            if (0 != i && 0 == i % row)
            {
                Console.WriteLine("");
            }

            if (SelectIndex == i)
            {
                Console.Write("▣ ");
            }

            else if (null == Inventory[i])
            {
                Console.Write("□ ");
            }

            else
                Console.Write("■ ");
        }

        Console.WriteLine();
        if (null != Inventory[SelectIndex])
        {
            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("이름 : " + Inventory[SelectIndex].Name);
            Console.WriteLine("가격 : " + Inventory[SelectIndex].Gold);
        }
        else
        {
            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("선택 슬롯이 비어있습니다.");
        }
    }

    public void ItemIn(Item _item)
    {
        for (int i = 0; i < Inventory.Length; i++)
        {
            int index = 0;

            if(null == Inventory[i])
            {
                index = i;
                break;
            }

            Inventory[index] = _item;
        }
    }
    public void ItemIn(Item _item, int _select)
    {
        if(null != Inventory[_select])
            return;

        // if(_select > )

        Inventory[_select-1] = _item;
    }
}