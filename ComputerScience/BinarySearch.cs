using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public static class BinarySearch
    {
        public static bool Search(List<int> list, int a)
        {
            int first = 0;
            int last = list.Count - 1;
            while (first < last)
            {
                int mid = (first + last) / 2;
                if (list[mid] == a)
                    return true;
                if (a < list[mid])
                    last = mid - 1;
                else
                    first = mid + 1;
            }
            return false;
        }
        public static bool Search(List<string> list, string a)
        {
            int first = 0;
            int last = list.Count - 1;
            byte[] stringEncode = Encoding.UTF8.GetBytes(a);
            while (first < last)
            {
                int mid = (first + last) / 2;
                byte[] listEncode = Encoding.UTF8.GetBytes(list[mid]);
                if (list[mid] == a)
                    return true;
                for (int i = 0; i < a.Length; i++)
                {
                    if (listEncode.Length <= i)
                        return false;
                    if (stringEncode[i] < listEncode[i])
                    {
                        last = mid - 1;
                        break;
                    }
                    else if (stringEncode[i] > listEncode[i])
                    {
                        first = mid + 1;
                        break;
                    }
                }
            }
            return false;
        }
    }
}
