using System;

class Program
{
    static void Main(string[] args)
    {
        PLAYER NewPlayer = new PLAYER();

        Inven NewInven = new Inven(5, 3);

        NewInven.InnerClassTest();
        
    }
}

