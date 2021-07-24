using System;

// 오버로딩
// 생성자
// static
// 멤버함수
// 전부 적용 가능


class Player
{
    public enum DAMAGETYPE
    {
        AD_DAMAGE,
        AP_DAMAGE
    }

    int HP = 100;
    int AD_D = 10;
    int AP_D = 5;

    // func overloading
    // 자료형 인식
    // Damageint <- process
    public void Damage(int Damage)
    {
        this.HP -= Damage;
    }

    public void Damage(float Damage)
    {

    }
    // Damageintint <- process
    public void Damage(int Damage, DAMAGETYPE Type)
    {
        switch (Type)
        {
            case DAMAGETYPE.AD_DAMAGE:
                Damage -= AD_D;
                break;
            case DAMAGETYPE.AP_DAMAGE:
                Damage -= AP_D;
                break;
            default:
                break;
        }

        this.Damage(Damage);
    }

    static void Func(int value)
    {

    }

    static void Func(int value1, int value2)
    {

    }
}

namespace OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NewPlayer.Damage(100, Player.DAMAGETYPE.AD_DAMAGE);
        }
    }
}
