
// Напишете програма, която намира максималната подредица от нараст­ващи елементи в масив arr[n]. Елементите може и да не са последо­вателни. Пример: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} --> {2, 4, 6, 8}.

using System;


namespace Zad._6
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете числов масив: ");
            string chArr = Console.ReadLine();
            char[] razd = new char[] { ',', ' ' };
            string[] razArr = chArr.Split(razd, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[razArr.Length];
            for (int i = 0; i < razArr.Length; i++)
            {
                arr[i] = int.Parse(razArr[i]);
            }
            int counter = 0;
            int maxSequence = 0;
            int index = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                counter = 1;
                int j = i + 1;
                int k = i;

                while (arr[k] < arr[j])
                {
                    counter++;
                    j++;
                    k++;
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
                    Console.Write(" " + arr[i] + ", ");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}