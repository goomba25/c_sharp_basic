using System;

class Player
{
    public int HP = 100;
    public int AT = 10;

    public void Test(Player _Player)
    {
        Test1(_Player);
    }
    public void Test1(Player _Player)
    {
        Test2(_Player);
    }
    public void Test2(Player _Player)
    {
        _Player.AT = 20;
    }
}
class Program
{
    static void PlayerTest(Player _Test)
    {
        _Test.AT = 1000;
    }

    static void ArrTest(int[] _arr)
    {
        _arr[0] = 999;
    }

    static void AtTest(Player _Test)
    {
        Console.WriteLine("공격력 테스트");
        _Test.AT = 1000;
    }
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NewPlayer.AT = 60;

        PlayerTest(NewPlayer);

        int[] Arr = new int[10] {0,1,2,3,4,5,6,7,8,9};

        ArrTest(Arr);

        Console.WriteLine(Arr[0]);

        NewPlayer.Test(null);
    }
}
