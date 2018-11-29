
// Напишете програма, която намира последователност от числа, чиито сума е максимална. Пример: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> 11

using System;


namespace Zad._9
{
    class Program
    {
        static void Main()
        {
            int sum = 0, tempSum;

            Console.Write(" Дължина на масива: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(" Въведете елемент {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                tempSum = arr[i];

                for (int j = i + 1; j < n; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > sum) sum = tempSum;
                }
            }

            Console.WriteLine(" Резултата е {0}. ", sum);
        }
    }
}