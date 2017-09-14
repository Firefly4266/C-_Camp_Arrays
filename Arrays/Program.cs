using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rand = new[] { 1, 2, 64, 6, 987, 5, 9874, 6, 64, 6, 2988, 26, 99, 3345, 89, 98, 10, 31, 77, 73, 17, 46 };
            int[] tree = new int[rand.Length];
            Console.WriteLine("\n This is the original array: \n");
            for (int i = 0; i < rand.Length; i++)
            {
                tree[i] = rand[i];
                Console.Write($" {tree[i]},");
            }
            Console.WriteLine("\n\n This is the new array\n");
            foreach(int t in tree)
            {
                Console.Write($" {t},");
            }
            Console.WriteLine();
        }
    }
}
