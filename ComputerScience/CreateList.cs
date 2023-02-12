using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public class CreateList
    {
        public static List<int> CreateIntList(Random random, int unit, int minValue = 0, int maxValue = int.MaxValue)
        {
            List<int> intList = new List<int>();
            for (int i = 0; i < unit; i++)
            {
                intList.Add(random.Next(minValue, maxValue));
            }
            return intList;
        }
        public static List<string> CreateStringList(Random random, int unit, int minValue = 0, int maxValue = int.MaxValue)
        {
            List<string> stringList = new List<string>();
            for (int i = 0; i < unit; i++)
            {
                byte[] bytes = new byte[random.Next(minValue, maxValue)];
                for (int j = 0; j < bytes.Length; j++)
                {
                    bytes[j] = (byte)random.Next(97, 122);
                }
                stringList.Add(Encoding.ASCII.GetString(bytes));
            }
            return stringList;
        }
    }
}
