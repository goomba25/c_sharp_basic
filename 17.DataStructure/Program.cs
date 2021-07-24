using System;
using System.Collections.Generic;

//  자료구조 -> 효율적 접근 및 수정 가능
//  데이터의 모임.관계.함수.명령

//  시퀸스 컨테이너 (순서대로 쌓이는 List)  // vector(c++)
//  연관 컨테이너 (규칙에 의한 차순 정리 SortedList, Dictionary, 해쉬맵) // map(c++)
//  어댑터 컨테이너 (stack queue)


class Item
{

}

// class MyList<T>
// {
//     int[] Arr;
//     int Capa = 0;
//     int Count = 0;

//     public void Add(T _value)
//     {
//         if(Count + 1 > Capa)
//         {
//             //확장
//         }

//     }
// }

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[10];
            Arr[0] = 0;
            Arr[1] = 1;

            //  List
            List<int> NewList = new List<int>();

            // List<Item> NewList2 = new List<Item>();

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine((NewList.Count + 1).ToString() + " Add");
                Console.WriteLine("Capa" + NewList.Capacity);   // 배열의 크기
                Console.WriteLine("Count" + NewList.Count); // 자료의 크기
                NewList.Add(i);
            }

            // MyList<int> NewInt = new MyList<int>();
            // NewInt.Add(100);

            //  내부에 자료의 존재여부
            //  탐색에 유리하지는 않음 (bool 타입)
            //  인덱스로 표현한다면 가장 유리함
            int num = 10;
            if(NewList.Contains(num))
            {
                Console.WriteLine("내부에" + num + "이 있습니다.");
            }
            else
            {
                Console.WriteLine("내부에" + num + "이 없습니다.");
            }

            // 인덱서 또는 연산자 겹지정
            // 자료의 크기 판단 O
            // 배열의 크기 판단 X
            Console.WriteLine(NewList[num-1]);
            // Console.WriteLine(NewList[99]); //  out of range

            
            // 존재시 삭제
            NewList.Remove(5);

            // 번째 삭제
            NewList.RemoveAt(1);

            // 중복 삭제
            // NewList.RemoveAll();
            
            //0번째부터 2개 삭제
            NewList.RemoveRange(0,2);
            for(int i = 0; i < NewList.Count; i ++)
            {
                if(((i+1)%3) == 0 && i != 0)
                {
                    Console.Write(i + "번째 ");
                    Console.WriteLine(NewList[i]);
                }
                else
                {
                    Console.Write(i + "번째 ");
                    Console.Write(NewList[i] + " ");
                }
            }

            
        }   
    }
}
