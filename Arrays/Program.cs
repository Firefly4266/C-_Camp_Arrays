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
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = Int32.MaxValue;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < currentMinimum) currentMinimum = array[index];
            }

            int[] array2 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            for (int index = 0; index < array2.Length; index++)
                total += array2[index];
            float average = (float)total / array2.Length;

            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int currentMinimum = Int32.MaxValue;
            //foreach (int arr in array)
            //{
            //    if (arr < currentMinimum) currentMinimum = arr;
            //}

            //int[] array2 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int total = 0;
            //foreach (int ar in array2)
            //    total += ar;
            //float average = (float)total / array2.Length;
        }
    }
}
