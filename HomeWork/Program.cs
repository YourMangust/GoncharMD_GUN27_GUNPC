using System.Diagnostics;
using System.Text;

namespace HomeWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {   //массивы заданий 1-4

            int[] fib = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };  //Фибоначчи

            string[] month = new string[12] { "January", "February", "March", "April", "May",
                "June", "July", "August", "September", "October", "November", "December"};

            int[,] matrix = new int[3, 3] {
                { 2, 3, 4},
                { 4, 9, 16},
                { 8, 27, 64}
            };

            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[5] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new double[2] { Math.E, Math.PI };
            jaggedArray[2] = new double[4] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            //массивы для заданий 5 и 6.

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            var result = CopyArrays(array, array2, 3);
            var result2 = ResizeArray(ref array, 10);

            static int[] CopyArrays(int[] source1, int[] source2, int elementsToCopy)
            {
                Array.Copy(source1, source2, elementsToCopy);
                return source2;
            }
            Console.WriteLine($"{result[0]} {result[1]} {result[2]} {result[3]} {result[4]} {result[5]} {result[6]}"); //Задание 5

            static int[] ResizeArray(ref int[] x, int newSize)
            {
                Array.Resize(ref x, newSize);
                return x;

            }

            Console.WriteLine($"{result2[0]} {result2[1]} {result2[2]} {result2[3]} {result2[4]} " +
                $"{result2[5]} {result2[6]} {result2[7]} {result2[8]} {result2[9]}"); //Задание 6

        }
    }
}