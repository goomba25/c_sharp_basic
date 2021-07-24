using System;

enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    NONSELECT
}

namespace text_rpg
{
    class Program
    {
        static int cnt = 0;

        static STARTSELECT StartSelect()
        {
            if(cnt != 0)
            {
                Console.Clear();
                if(cnt >= 100)
                    cnt = 1;
            }
            else
            {
                cnt++;
                Console.WriteLine("");
            }
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 필드");
            Console.WriteLine("어디로 가시겠습니까?");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\b ");
                    Console.WriteLine("마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("\b ");
                    Console.WriteLine("필드로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("\b ");
                    Console.WriteLine("잘못 선택하셨습니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONSELECT;
            }
        }

        static void Shop(Player _Player, Inven _ShopInven)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("SHOP");
                _ShopInven.Render();
                Console.WriteLine("Player");
                _Player.P_Inven.Render();

                Console.ReadKey(); 
            }
        }
        static void Town(Player _Player)
        {
            Inven ShopInven = new Inven(5, 3);

            ShopInven.ItemIn(new Item("철검", 1000));
            ShopInven.ItemIn(new Item("갑옷", 700));
            ShopInven.ItemIn(new Item("방패", 500));
            ShopInven.ItemIn(new Item("신발", 300));

            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 상점을 이용한다.");
                Console.WriteLine("3. 마을을 나간다.");
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\b ");
                        _Player.Heal();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\b ");
                        Shop(_Player, ShopInven);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\b ");
                        Console.WriteLine("마을을 나갑니다.");
                        Console.ReadKey();
                        return;
                }
            }
        }

        static void Battle(Player _Player)
        {
            Console.Clear();
            Console.WriteLine("배틀이 시작됩니다.");

            Monster Oak = new Monster("오크",100,100,20);
            while (!Oak.IsDeath() && !_Player.IsDeath())
            {
                _Player.StatusRender();
                Oak.StatusRender();
                Console.ReadKey();

                _Player.Attack(Oak);
                if(false == Oak.IsDeath())
                {
                    Oak.Attack(_Player);
                }
                Console.Clear();
            }

            Console.WriteLine("배틀이 끝났습니다.");
            Console.ReadKey();

            Console.WriteLine("마을로 이동합니다.");
            Console.ReadKey();
            Town(_Player);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("입장을 환영합니다.");
            Console.Write("플레이어의 이름을 입력하세요 : ");
            string Me = Console.ReadLine();
            Player Player = new Player(Me);

            //마을, 배틀필드
            while(true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(Player);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(Player);
                        break;
                }
            }
        }
    }
}