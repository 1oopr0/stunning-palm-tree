using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortLibrary;

namespace SortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MySortedList<int>();

            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                list.Add(r.Next(0, 10000000));
            }

            var timer = Stopwatch.StartNew();

            list.MergeSort();

            timer.Stop();

            Console.WriteLine(timer.Elapsed);

            timer.Restart();
            list.IntArrayQuickSort();

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
        }
    }

}
