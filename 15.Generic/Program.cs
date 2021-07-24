using System;


//  제네릭 함수
//  멤버함수에 통용
//  함수 식별자 <대표할 이름>
//  제네릭 클래스 사용 가능

class GameItem
{

}

class CashItem
{

}
class Inven<T>
{
    T[] Inven_Item;

    public void ItemIn(T _Item)
    {

    }
}




static class GTest
{
    public static void ConsolePrint(int _Value)
    {
        Console.WriteLine(_Value);
    }
    public static void ConsolePrint(string _Text)
    {
        Console.WriteLine(_Text);
    }

    public static T ConsolePrint<T>(T _Value)
    {
        Console.WriteLine(_Value);
        return _Value;
    }

    public static T ConsolePrint<T,U>(T _Value1, U _Value2)
    {
        Console.WriteLine(_Value1);
        Console.WriteLine(_Value2);
        return _Value1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        GTest.ConsolePrint(1000);
        GTest.ConsolePrint(1.02f);
        GTest.ConsolePrint("하하하");
        GTest.ConsolePrint("ddd", "aaa");

        // 무조건 명시적으로 만들어준다.
        Inven<GameItem> NewGameItemInven = new Inven<GameItem>();
        GameItem NewGameItem = new GameItem();
        NewGameItemInven.ItemIn(NewGameItem);
        
        Inven<CashItem> NewCashItemInven = new Inven<CashItem>();
        CashItem NewCashItem = new CashItem();
        NewCashItemInven.ItemIn(NewCashItem);
    }
}
