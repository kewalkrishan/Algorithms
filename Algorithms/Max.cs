using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Max
    {
        public static int FindMax(this int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }

        public static int FindMin(this int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            return min;
        }

        //public static void FindMaxMin(this int[] array, out int max, out int min)
        //{
        //    int mid = array.Length / 2;
        //    int l = 0, h = array.Length - 1;
        //    int min1, max1, min2, max2, mid1, mid2;
        //    while (mid > 0)
        //    {
        //        mid1 = l + mid / 2;
        //        mid2 = mid + 1 + h + 1 / 2;
        //        if (mid1 == l)
        //        {

        //        }
        //    }
        //}

        public static void FindMaxMinRecursively(this int[] array, out int max, out int min)
        {
            MaxMin(array, 0, array.Length - 1, out max, out min);
        }

        private static void MaxMin(int[] array, int start, int last, out int max, out int min)
        {
            if (start == last)
            {
                max = min = array[start];
            }
            else if (start == last - 1)
            {
                if (array[start] > array[last])
                {
                    max = array[start];
                    min = array[last];
                }
                else
                {
                    min = array[start];
                    max = array[last];
                }
            }
            else
            {
                int mid = (start + last) / 2;
                int min1, max1, min2, max2;
                MaxMin(array, start, mid, out max1, out min1);
                MaxMin(array, mid + 1, last, out max2, out min2);
                max = max1 > max2 ? max1 : max2;
                min = min1 < min2 ? min1 : min2;
            }
        }
    }
}
