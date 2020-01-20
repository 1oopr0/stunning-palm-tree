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

        private void QuickSort(int l, int r)
        {
            int i, j;
            T x;

            i = l;
            j = r;

            x = this[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (this[i].CompareTo(x) == -1)
                    i++;
                while (x.CompareTo(this[j]) == -1)
                    j--;
                if (i <= j)
                {
                    exchange(i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                QuickSort(l, j);
            if (i < r)
                QuickSort(i, r);
        }

        private void exchange(int m, int n)
        {
            T temporary;

            temporary = this[m];
            this[m] = this[n];
            this[n] = temporary;
        }

        public void QuickSort()
        {
            QuickSort(0, this.Count - 1);
        }

        public void MergeSort()
        {
            var len = this.Count;

            MergeSort(0, len - 1);
        }

        private void MergeSort(int start, int end)
        {
            if(start < end)
            {
                var mid = (start + end) / 2;
                MergeSort(start, mid);
                MergeSort(mid + 1, end);
                MergeSort(start, mid, end);
            }
        }

        private void MergeSort(int start, int mid, int end)
        {
            var i = 0;
            var j = 0;
            var list = this.ToList();

            while(start + i <= mid && mid + 1 + j <= end)
            {
                var f = list[start + i];
                var s = list[mid + 1 + j];
                if (f.CompareTo(s) == 1)
                {
                    this[start + i + j] = s;
                    j++;
                }
                else
                {
                    this[start + i + j] = f;
                    i++;
                }
            }

            while(start + i <= mid)
            {
                this[start + i + j] = list[start + i];
                i++;
            }

            while (mid + 1 + j <= end)
            {
                this[start + i + j] = list[mid + 1 + j];
                j++;
            }
        }
     }
}
