using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 5, 9, 1, 4, 6, 7, 3, 2, 8 };

            int[] sorted = insSort(arr);

            for (int i = 0; i < sorted.Length; i++)
                Console.Write(sorted[i] + " ");

            Console.ReadKey();

        }

        static int[] insSort(int[] array)
        {
 
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while ((j > 0) && (array[j] < array[j - 1]))
                {
                    int temp = array[j -1];
                    array[j - 1] = array[j];
                    array[j] = temp;

                    j--;
                }
            }
            return array;
        }
    }
}
