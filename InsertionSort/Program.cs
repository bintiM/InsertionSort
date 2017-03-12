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
            Console.WriteLine("unsortiertes Array");
            int[] arr = { 5, 9, 1, 4, 6, 7, 3, 2, 8 };

            foreach(int i in arr)
                Console.Write(i + " ");


            Console.WriteLine("\nsortiertes Array");
            int[] sorted = insSort(arr);

            for (int i = 0; i < sorted.Length; i++)
                Console.Write(sorted[i] + " ");

            Console.ReadKey();

        }

        static int[] insSort(int[] array)
        {
 
            for (int i = 1; i < array.Length; i++) //ganzes Array einmal durch
            {
                int j = i; // aktuelle Startposition für innere Schleife setzen

                while ((j > 0) && (array[j] < array[j - 1])) // wenn der rechte Wert kleiner ist als der linke
                {
                    int temp = array[j - 1]; // linken Wert merken
                    array[j - 1] = array[j]; // rechten Wert nach links setzen
                    array[j] = temp; // gemerkte Wert nach rechts setzen

                    j--; // Iterator verkleinern, d.h. die innere Schleife geht nach links bis zum Anfang
                }
            }
            return array;
        }
    }
}
