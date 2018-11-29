
// Да се напише програма, която чете два масива от конзолата и прове­рява дали са еднакви.

using System;


namespace Zad._2
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Размер на масив 1: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n1];

            Console.Write(" Размер на масив 2: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[n2];
            Console.WriteLine(" ");
             for (int i = 0; i < arr1.Length; i++)
             {
                Console.Write(" Въведете елементите на масив 1: ");
                arr1[i] = int.Parse(Console.ReadLine());
             }
            Console.WriteLine(" ");
             for (int i = 0; i < arr2.Length; i++)
             {
                Console.Write(" Въведете елементите на масив 2: ");
                arr2[i] = int.Parse(Console.ReadLine());
             }
             Console.WriteLine(" ");
              if (arr1.Length == arr2.Length)
              {
                int m = arr1.Length;
                 for (int i = 0; i < m; i++)
                 {
                    if (arr1[i] == arr2[i])
                    {
                        Console.WriteLine(" Maсивите са еднакви !");
                    }
                    else
                    {
                        Console.WriteLine(" Maсивите са различни !");
                    }
                 }
              }
              else
              {
              Console.WriteLine(" Maсивите са различни !");
              }
        }
    }
}
