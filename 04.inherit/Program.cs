using System;

/*
    상속화
    코드의 재활용 향상

    c#은 단일 클래스상속만 가능

    protected 상속 사용
*/
class Unit
{
    protected string Name;
    protected int HP;
    protected int MAXHP;
    protected int AT;

    public void StatusRender()
    {
        Console.WriteLine(Name + "의 능력치");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("공격력 : " + AT);
        Console.WriteLine("체력 : " + HP + "/" + MAXHP);
        Console.WriteLine("-----------------------------");
    }
}

class Player:Unit
{
    public Player(string Name) //Constructor
    {
        this.Name = Name;
        this.HP = 50;
        this.MAXHP = 1000;
        this.AT = 20;
    }

    public void Heal()
    {
        if(HP >= MAXHP)
        {
            Console.WriteLine("\nHP가 이미 가득 찼습니다.");
            Console.ReadKey();
        }
        else
        {
            this.HP = MAXHP;
            Console.WriteLine("\n현재 플레이어의 HP는" + HP + "입니다.");
            Console.ReadKey();
        }
    }

}

class Monster:Unit
{
    public Monster(string Name, int HP, int MAXHP, int AT)
    {
        this.Name = Name;
        this.HP = HP;
        this.MAXHP = MAXHP;
        this.AT = AT;
    }
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
                        _Player.Heal();
                        break;
                    case ConsoleKey.D2:
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
            Console.WriteLine("오픈 예정입니다.");
            Console.ReadKey();
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