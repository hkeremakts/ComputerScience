using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    var tempVar = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = tempVar;
                    j--;
                }
            }
            return array;
        }
        public static string[] Sort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int k = i;
                while (k > 0 && array[k].CompareTo(array[k - 1]) < 0)
                {
                    var tempVar = array[k];
                    array[k] = array[k - 1];
                    array[k - 1] = tempVar;
                    k--;
                }
            }
            return array;
        }

    }
}
