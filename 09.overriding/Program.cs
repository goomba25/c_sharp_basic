using System;

//  오버라이딩
//  생성자 불가능
//  Property 가능
//  접근제한지정자 protected, private, public 동일하게 지정
//  static 안됨 (this 부재)


class Unit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 100;

    public void Attack(Unit _Unit)
    {
        int AT = this.GetAT;
        Console.WriteLine(this.Name + "가 " + _Unit.Name + "에게 " + AT + "만큼의 데미지를 입혔습니다.");
        HP -= AT;
    }

    // public virtual int GetAT()  //  virtual -> override
    // {
    //     Console.WriteLine("Unit GetAT");
    //     return AT;
    // }

    public virtual int GetAT
    {
        get
        {
            return AT;
        }
    }
}
class Player:Unit
{
    int ItemAT = 5;

    public Player() //  overloading
    {
        
    }
    public Player(string _Name) //  overloading
    {
        this.Name = _Name;
    }

    // public override int GetAT()
    // {
    //     Console.WriteLine("Player GetAT");
    //     return AT + ItemAT;
    // }

    public override int GetAT
    {
        get
        {
            Console.WriteLine("Player GetAT");
            return AT + ItemAT;
        }
    }
    
}

class Monster:Unit
{
    int MonsterLV;
    public Monster(string _Name, int _MonsterLV)
    {
        this.Name = _Name;
        this.MonsterLV = _MonsterLV;
    }

    // public override int GetAT()
    // {
    //     Console.WriteLine("Monster GetAT");
    //     return AT + MonsterLV;
    // }

    public override int GetAT
    {
        get
        {
        Console.WriteLine("Monster GetAT");
        return AT + MonsterLV;
        }
    }
}



namespace overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster NewMonster = new Monster("Slime", 2);
            Player NewPlayer = new Player("서한승");

            NewPlayer.Attack(NewMonster);   //  upcasting
            NewMonster.Attack(NewPlayer);   //  overriding
            
        }
    }
}
