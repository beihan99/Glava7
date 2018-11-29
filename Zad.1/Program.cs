
// Да се напише програма, която създава масив с 20 елемента от целочислен тип и инициализира всеки от елементите със стойност равна на индекса на елемента умножен по 5. Елементите на масива да се изведат на конзолата.

using System;


namespace Zad._1
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[20];
            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                n++;
                arr[i] = n * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}

