using System;


// 디버깅
// 문자열
// 파일입출력

namespace _Property
{
    class Player
    {
        int AT;

        public int HP = 20;

        static int m_StaticValue = 100;
        static public int StaticValue
        {
            get
            {
                return m_StaticValue;
            }

            set
            {
                m_StaticValue = value;
            }
        }
        public int ProAT    // 인자값 X
        {
            get //int return
            {
                if(AT > 999)
                {
                    Console.WriteLine("최대 수정치를 넘겼습니다.");
                }
                return AT;
            }

            set //int 인자값
            {
                AT = value;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Player NewPlayer = new Player();

                NewPlayer.HP = 80;
                Player.m_StaticValue = 200;

                int Value = NewPlayer.ProAT;
                Console.WriteLine(Value);
                NewPlayer.ProAT = 100;
                Value = NewPlayer.ProAT;
                Console.WriteLine(Value);
                
            }
        }
    }
}
