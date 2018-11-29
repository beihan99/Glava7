﻿
// Да се напише програма, която намира най-дългата последователност от еднакви stringелементи в матрица. Последователност в матрица дефинираме като елементите са на съседни и са на същия ред,колона или диагонал.

using System;


namespace Zad._14
{
    class Program
    {
        static void Main()
        {
            int tempSeq = 1, seq = 1;
            string element = "e";

            Console.Write(" Въведете редове: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Въведете колони: ");
            int m = int.Parse(Console.ReadLine());

            string[,] arr = new string[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" Елемент(A{0}{1}) = ", i + 1, j + 1);
                    arr[i, j] = Console.ReadLine();
                }


            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1) - 1; cols++)
                {
                    if (arr[rows, cols] == arr[rows, cols + 1]) tempSeq++;
                    else tempSeq = 1;

                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr[rows, cols];
                    }
                }
                tempSeq = 1;
            }

            for (int cols = 0; cols < arr.GetLength(1); cols++)
            {
                for (int rows = 0; rows < arr.GetLength(0) - 1; rows++)
                {
                    if (arr[rows, cols] == arr[rows + 1, cols]) tempSeq++;
                    else tempSeq = 1;

                    if (seq < tempSeq)
                    {
                        seq = tempSeq;
                        element = arr[rows, cols];
                    }
                }
                tempSeq = 1;
            }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    for (int rows = i, cols = j; rows < arr.GetLength(0) - 1 && cols < arr.GetLength(1) - 1; rows++, cols++)
                    {
                        if (arr[rows, cols] == arr[rows + 1, cols + 1]) tempSeq++;
                        else tempSeq = 1;

                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr[rows, cols];
                        }
                    }
                    tempSeq = 1;
                }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    for (int rows = i, cols = j; rows < arr.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (arr[rows, cols] == arr[rows + 1, cols - 1]) tempSeq++;
                        else tempSeq = 1;

                        if (seq < tempSeq)
                        {
                            seq = tempSeq;
                            element = arr[rows, cols];
                        }
                    }
                    tempSeq = 1;
                }

            for (int i = 0; i < seq; i++) Console.Write(" Диагонал от еднакви елементи: {0}, ", element);
        }
    }
}
