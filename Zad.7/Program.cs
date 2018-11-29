
// Да се напише програма, която чете от конзолата две цели числа N и K (K<N), и масив от N елемента. Да се намерят тези K поредни елемента, които имат максимална сума.

using System;


namespace Zad._7
{
    class Program
    {
        static void Main()
        {
            int sum = 0;

            Console.Write(" Въведете N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Въведете K (K < N): ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(" Въведете елемент {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr[i];

            Console.WriteLine(" Максимална сума е {0}", sum);
        }
    }
}