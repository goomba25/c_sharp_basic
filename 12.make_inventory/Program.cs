using System;

//  객채지향 5 원칙
//  1. 단일 책임 원칙
//  2. 개방 폐쇠 원칙
//  3. 리스코브 치환 원칙
//  4. 인터페이스 분리 원칙
//  5. 의존성 역전 원칙


namespace make_inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inven NewInven = new Inven(5,3);

            NewInven.ItemIn(new Item("철검", 1000));
            NewInven.ItemIn(new Item("방패", 1000));
            NewInven.ItemIn(new Item("포션", 1000), 4);

            while (true)
            {`
                Console.Clear();
                NewInven.Render();

                ConsoleKeyInfo Check_Key = Console.ReadKey();

                switch (Check_Key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        NewInven.SelectMoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        NewInven.SelectMoveRight();
                        break;
                    case ConsoleKey.UpArrow:
                        NewInven.SelectMoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        NewInven.SelectMoveDown();
                        break;
                    default:
                        break; 
                }
            }

        }
    }
}
