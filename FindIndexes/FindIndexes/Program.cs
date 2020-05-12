using System;

namespace FindIndexes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[16] { 1, 2, 3, 41, 4, 31, 5, 2, 6, 2, 6, 7, 4, 324, 12, 432 };
            int value;

            Console.Write("intput number: ");

            value = int.Parse(Console.ReadLine());

            var arrLength = arr.Length;

            for(var i = 0; i < arrLength - 1; i++)
            {
                for(int j=0;j<arrLength-1;j++)
                {
                    if (arr[i] + arr[j] == value)
                    {
                        Console.WriteLine($"{i}  {j}");
                    }
                }
            }
        }
    }
}
