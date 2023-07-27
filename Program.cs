using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timphantulonnhatmang2chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            {
                int[,] arr = {
            { 1, 3, 5 },
            { 7, 2, 4 },
            { 9, 6, 8 }
        };

                int maxElement = FindMaxElement(arr);
                Console.WriteLine("Phần tử lớn nhất trong mảng là: " + maxElement);
            }
        }
        static int FindMaxElement(int[,] arr)
        {
            int maxElement = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > maxElement)
                    {
                        maxElement = arr[i, j];
                    }
                }
            }
            return maxElement;
        }
    }
}
