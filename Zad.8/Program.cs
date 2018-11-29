
// Сортиране на масив означава да подредим елементите му в нарастващ (намаляващ) ред. Напишете програма, която сортира масив. Да се използва алгоритъма "Selection sort".

using System;


namespace Zad._8
{
    class Program
    {
        static void Main()
        {

            int i, j, iMin, temp;

            Console.Write(" Дължина на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (i = 0; i < length; i++)
            {
                Console.Write(" Въведете елемент {0}: ", i+1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (j = 0; j < length - 1; j++)
            {
                iMin = j;

                for (i = j + 1; i < length; i++) if (arr[i] < arr[iMin]) iMin = i;

                if (iMin != j)
                {
                    temp = arr[j];
                    arr[j] = arr[iMin];
                    arr[iMin] = temp;
                }
            }
            Console.Write(" Подредената последователност: ");
            for (i = 0; i < length; i++) Console.Write("{0}, ", arr[i]);
        }
    }
}