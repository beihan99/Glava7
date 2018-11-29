
// Да се напише програма, която сравнява два масива от тип char лексикографски (буква по буква) и проверява кой от двата е по-рано в лексикографската подредба.

using System;


namespace Zad._3
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете масив 1: ");
            string m = Console.ReadLine();
            Console.Write(" Въведете масив 2: ");
            string n = Console.ReadLine();

            char[] arr1 = m.ToCharArray();
            char[] arr2 = n.ToCharArray();

            int i = 0;
            int j = 0;
            bool equal = false;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] > arr2[j])
                {
                    Console.WriteLine(" В лексикографската подредба I-ви е: {0}",n);
                    equal = false;
                    break;
                }
                else if (arr1[i] < arr2[j])
                {
                    Console.WriteLine(" В лексикографската подредба I-ви е: {0}",m);
                    equal = false;
                    break;
                }
                else
                {
                    equal = true;
                }

                i++;
                j++;
            }

            if (equal == true)
            {
                if (arr1.Length < arr2.Length)
                {
                    Console.WriteLine(" В лексикографската подредба I-ви е: {0}",m);
                }
                else if (arr1.Length > arr2.Length)
                {
                    Console.WriteLine(" В лексикографската подредба I-ви е: {0}",n);
                }
                else
                {
                    Console.WriteLine(" Масивите са еднакви !");
                }
            }

        }
    }
}
