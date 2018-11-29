
// Напишете програма, която създава следните квадратни матрици и ги извежда на конзолата във форматиран вид. Размерът на матриците се въвежда от конзолата. Пример за (4,4).

using System;


namespace Zad._12
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете редове: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write(" Въведете колони: ");
            int cols = int.Parse(Console.ReadLine());

             int[,] matrix = new int[rows, cols];
              for (int row = 0; row < rows; row++)
              {

                for (int col = 0; col < cols; col++)
                {

                    Console.Write(" matrix(A{0}{1}) = ", row+1, col+1);

                    matrix[row, col] = int.Parse(Console.ReadLine());
                }

              }
              for (int row = 0; row < matrix.GetLength(0); row++)

              {

                for (int col = 0; col < matrix.GetLength(1); col++)

                {

                    Console.Write(" " + matrix[row, col]);

                }

                Console.WriteLine();

            }
        }
    }
}
