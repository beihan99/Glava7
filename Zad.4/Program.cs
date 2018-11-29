
// Напишете програма, която намира максимална редица от последова­телни еднакви елементи в масив. Пример: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} --> {2, 2, 2}.

using System;


namespace Zad._4
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете числов масив: ");
            string chArr = Console.ReadLine();
            char[] razd = new char[] { ',' , ' ' };
            string[] razArr = chArr.Split(razd, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[razArr.Length];
            for (int i = 0; i < razArr.Length; i++)
            {
                arr[i] = int.Parse(razArr[i]);
            }
            int counter = 0;
            int maxSequence = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                int j = i;

                while (arr[i] == arr[j])
                {
                    counter++;
                    j++;
                    if (j >= arr.Length)
                    {
                        break;
                    }
                }

                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    index = i;
                }
            }

            for (int i = index; i <= index + maxSequence - 1; i++)
            {
                if (i != index + maxSequence - 1)
                {

                   
                    Console.Write(" "+arr[i] + ", ");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
}