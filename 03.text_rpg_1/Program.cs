using System;

class Player
{
    int AT = 50;
    int HP = 100;
    int MAXHP = 1000;

    public void StatusRender()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("공격력 : " + AT);
        Console.WriteLine("체력 : " + HP + "/" + MAXHP);
        Console.WriteLine("-----------------------------");
    }
    public void Heal()
    {
        if(HP >= MAXHP)
        {
            Console.WriteLine("HP가 이미 가득 찼습니다.");
            Console.ReadKey();
        }
        else
        {
            this.HP = MAXHP;
            Console.WriteLine("HP를 회복했습니다.");
            Console.ReadKey();
        }
    }

}

class Monster
{

}

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

        static void Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
                Console.WriteLine("1. 휴식을 취한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\b ");
                        Console.WriteLine("휴식을 취합니다.");
                        _Player.Heal();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\b ");
                        return;
                }
            }
        }

        static void Battle(Player _Player)
        {
            Console.WriteLine("오픈 예정입니다.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Player Player1 = new Player();

            Console.WriteLine("입장을 환영합니다.");
            //마을, 배틀필드
            while(true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(Player1);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(Player1);
                        break;
                }
            }
        }
    }
}
