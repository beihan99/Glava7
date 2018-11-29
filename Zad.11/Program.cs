
// Да се напише програма, която намира последователност от числа в масив, които имат сума равна на число, въведено от конзолата (ако има такава). Пример: {4, 3, 1, 4, 2, 5, 8}, S=11 --> {4, 2, 5}.

using System;


namespace Zad._11
{
    class Program
    {
        static void Main()
        {
            int sum = 0, start = 0, end = 0;
            bool sumFound = false;

            Console.Write(" Въведете Число(S): ");
            int s = int.Parse(Console.ReadLine());

            Console.Write(" Дължина на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write(" Елемент на масива {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                sum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        start = i;
                        end = j;
                        sumFound = true;
                        break;
                    }
                }

                if (sumFound) break;
            }

            if (sumFound)
            {
                Console.Write(" Редица равна на S:");
                  for (int i = start; i <= end; i++)
                  {
                    Console.Write(" {0} ",arr[i]);
                  }
            }
            else Console.WriteLine(" Няма редица равна на S !");
        }
    }
}