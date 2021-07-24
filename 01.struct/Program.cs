using System;


struct StructData //구조체
{
    public int a;
    public int b;

    public void Func()
    {
        a = 100;
        b = 100;
    }
}


namespace _01
{
    class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
            Console.WriteLine(_Data.a);
        }

        static void Main(string[] args)
        {
            StructData NewData = new StructData();

            NewData.a = 10;
            NewData.b = 10;

            Console.WriteLine(NewData.a);

            Test(NewData);

            Console.WriteLine(NewData.a);
        }
    }
}
