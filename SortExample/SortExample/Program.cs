using System;
using System.Collections.Generic;
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
            var list = new MySortedList<int>() { 8, 9, 2, 30, 81, -4, 847, -1028, 284, 12, -7, -4, 81 };

            list.BubbleSort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}
