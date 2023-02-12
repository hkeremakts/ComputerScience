using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            var n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swap = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tempVar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempVar;
                        swap = false;
                    }
                }
                if (swap)
                {
                    return array;
                }
            }
            return array;
        }
        public static string[] Sort(string[] array)
        {
            var n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swap = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var tempVar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempVar;
                        swap = false;
                    }
                }
                if (swap)
                {
                    return array;
                }
            }
            return array;
        }
    }
}
