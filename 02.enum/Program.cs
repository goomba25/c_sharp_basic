using System;

//사용자 정의 자료형
// class
// struct
// enum

enum ITEMTYPE
{
    EQUIP,
    POTION,
    QUEST
}

enum JOB
{
    ARCHOR,
    WARRIOR
}

class Item
{
    public ITEMTYPE ItemType = ITEMTYPE.POTION;

    public void PotionTypeSetting()
    {
        ItemType = ITEMTYPE.POTION;
    }
}

namespace _Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            NewItem.ItemType = ITEMTYPE.POTION;

            Console.WriteLine(ITEMTYPE.POTION);
            Console.WriteLine((int)ITEMTYPE.POTION);

            ITEMTYPE Type = ITEMTYPE.POTION;

            switch (Type)
            {
                case ITEMTYPE.EQUIP:
                    break;
                case ITEMTYPE.POTION:
                    break;
                case ITEMTYPE.QUEST:
                    break;
                default:
                    break;
            }
        }
    }
}
