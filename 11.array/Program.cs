using System;

//  배열 array
//  자료형, class 가능

namespace Array
{
    class Player
    {
        private int mAT;
        public int AT
        {
            get
            { return mAT; }
            set
            { mAT = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = new int[10];
            // for(int i = 0; i < arr.Length; i ++)
            // {
            //     Console.WriteLine(arr[i]);
            // }

            // Item[] item = new Item[10];
            // for (int i = 0; i < item.Length; i++)
            // {
            //     item[i] = new Item();
            // }

            // Player NewPlayer1 = new Player();
            // Player NewPlayer2 = null;   //  null
            // Console.WriteLine(NewPlayer1.AT);
            // Console.WriteLine(NewPlayer2.AT);   //  System.NullReferenceException

            Inven NewInven = new Inven(5,3);
            //□ □ □ □ □
            //□ □ □ □ □
            //□ □ □ □ □

            NewInven.ItemIn(new Item("철검", 1000));
            NewInven.ItemIn(new Item("방패", 1000));
            NewInven.ItemIn(new Item("포션", 1000), 100);

            while (true)
            {
                NewInven.Render();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
