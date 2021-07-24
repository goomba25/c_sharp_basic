using System;

//  사용자 정의 함수
//  함수의 형태만 선언
//  함수 구현 강제 (상속시 반드시 사용)
//  다중 상속 가능 (충돌 X)


interface QUESTUnit1
{
    void Talk(QUESTUnit1 _Unit);
}

interface QUESTUnit2
{
    void Talk(QUESTUnit1 _Unit);
    void Event(QUESTUnit2 _Unit);
}

class Unit
{
    protected int AT;
    protected int HP;

    public void Attack()
    {

    }
}

class Player:Unit, QUESTUnit1, QUESTUnit2
{
    public void Talk(QUESTUnit1 _Unit)
    {

    }

    public void Event(QUESTUnit2 _Unit)
    {

    }
}

class NPC:Unit, QUESTUnit1
{
    public void Talk(QUESTUnit1 _Unit)
    {

    }
}


namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NPC NewNPC = new NPC();

            NewPlayer.Talk(NewNPC); //  upcasting
            NewNPC.Talk(NewPlayer); //  upcasting

        }
    }
}
