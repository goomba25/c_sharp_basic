using System;

class Unit
{
    protected string Name;
    protected int HP;
    protected int MAXHP;
    protected int AT;

    public bool IsDeath()
    {
        return (HP <= 0);
    }
    public void StatusRender()
    {
        Console.WriteLine(Name + "의 능력치");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("공격력 : " + AT);
        Console.WriteLine("체력 : " + HP + "/" + MAXHP);
        Console.WriteLine("-----------------------------");
    }

    public void Attack(Unit _Unit)
    {
        _Unit.HP -= this.AT;
        if(_Unit.HP <= 0)
        {
            _Unit.HP = 0;
        }
        Console.WriteLine(this.Name + "가 " + _Unit.Name + "을 공격했습니다.");
        Console.ReadKey();
    }
}