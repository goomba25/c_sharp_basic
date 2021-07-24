using System;

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