using System;

class Player:Unit
{
    private Inven PlayerInven = new Inven(5, 3);
    public Inven P_Inven
    {
        get{return PlayerInven;}
    }
    
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
