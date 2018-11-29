
// Да се напише програма, която създава правоъгълна матрица с размер n на m. Размерността и елементите на матрицата да се четат от конзолата. Да се намери подматрицата с размер (3,3), която има максимална сума.

using System;


namespace Zad._13
{
    class Program
    {
        static void Main()
        {
            int row = 0, col = 0, sum = -1000;

            Console.Write(" Въведете редове: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Въведете колони: ");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" Елемент(A{0}{1}) = ", i + 1, j + 1);
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }

            for (int tempRow = 0; tempRow < arr.Length - 2; tempRow++)
                for (int tempCol = 0; tempCol < arr.GetLength(0) - 2; tempCol++)
                {
                    int tempSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] +
                        arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2] +
                        arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                    if (tempSum > sum)
                    {
                        row = tempRow;
                        col = tempCol;
                        sum = tempSum;
                    }
                }
            Console.WriteLine(" ");
            Console.WriteLine(" Mатрица: ");
            Console.WriteLine(" {0} {1} {2} ", arr[row, col], arr[row, col + 1], arr[row, col + 2]);
            Console.WriteLine(" {0} {1} {2} ", arr[row + 1, col], arr[row + 1, col + 1], arr[row + 1, col + 2]);
            Console.WriteLine(" {0} {1} {2} ", arr[row + 2, col], arr[row + 2, col + 2], arr[row + 2, col + 2]);
            Console.WriteLine("  Максималната сума е {0}.", sum);

        }
    }
}
