using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLibrary
{
    public class MySortedList<T> : List<T> where T : IComparable
    {
        public void BubbleSort()
        {
            var len = this.Count;

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
                {
                    var f = this[j];
                    var s = this[j + 1];
                    if (f.CompareTo(s) == 1)
                    {
                        this[j] = s;
                        this[j + 1] = f;
                    }
                }
            }
        }
    }
}
