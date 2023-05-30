using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //int[] arr = { 29, 72, 98, 13, 87, 66, 52, 51, 36};
            int[] arr = new int[100];
            int temp = 0; // just for sorting
            //int x = 0; // just represents the number of passes
            int swapIndex = 0; // index it is going to get swapped with
            int leastNumber = 0; // this is the least number
            int compCount = 0; // counts the number of comparisons made by the algorithms

            for (int x = 0; x < arr.Length; x++)
                arr[x] = rnd.Next(100);

            Console.WriteLine("Displatying unsorted array of numbers...");
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write(arr[x] + "\t");
                if (x > 0 && (x + 1) % 10 == 0)
                    Console.WriteLine();
            }

            for (int x = 0; x < arr.Length - 1; x++)
            {
                leastNumber = arr[x];
                swapIndex = -1;
                for (int y = x + 1; y < arr.Length; y++)
                /* 
                 * inner loop
                 * actively searches for the index to swap with
                 */
                {
                    if (leastNumber >= arr[y])
                    {
                        leastNumber = arr[y];
                        swapIndex = y;
                    }
                    compCount++;
                }

                // proceeds with swap
                Console.ResetColor();
                if (swapIndex > x)
                {
                    Console.WriteLine("Swapping {0} with {1}", arr[x], arr[swapIndex]);
                    temp = arr[x]; // holds the value of arr[x] into temp
                    arr[x] = arr[swapIndex]; // updates the value of arr[x] into the value of arr[swapIndex]
                    arr[swapIndex] = temp; // updates the value of arr[swapIndex] into the value held in temp
                }
                else
                    Console.WriteLine("Not swapping {0} with anything", arr[x]);

                for (int y = 0; y < arr.Length; y++)
                {
                    if (y == x)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (y == swapIndex)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ResetColor();
                    Console.Write(arr[y] + "\t");
                    if ((y + 1) % 10 == 0)
                        Console.WriteLine();
                }
                Console.WriteLine();

                //Console.ReadKey();
            }
            Console.WriteLine("Number of comparisons made : {0}", compCount);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
