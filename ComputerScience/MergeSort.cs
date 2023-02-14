using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience
{
    public class MergeSort
    {
        static int[] Sort(int[] array)
        {
            if (array.Length > 1)
            {
                int mid = array.Length / 2;
                int[] leftHalf = new int[mid];
                int[] rightHalf = new int[array.Length - mid];
                for (int i = 0; i < mid; i++)
                    leftHalf[i] = array[i];
                for (int i = 0; i < array.Length - mid; i++)
                    rightHalf[i] = array[mid + i];
                Sort(leftHalf);
                Sort(rightHalf);
                int leftCounter = 0;
                int rightCounter = 0;
                int listCounter = 0;
                while (leftCounter < leftHalf.Length && rightCounter < rightHalf.Length)
                {
                    if (leftHalf[leftCounter] <= rightHalf[rightCounter])
                    {
                        array[listCounter] = leftHalf[leftCounter];
                        leftCounter++;
                    }
                    else
                    {
                        array[listCounter] = rightHalf[rightCounter];
                        rightCounter++;
                    }
                    listCounter++;
                }
                while (leftCounter < leftHalf.Length)
                {
                    array[listCounter] = leftHalf[leftCounter];
                    listCounter++;
                    leftCounter++;
                }
                while (rightCounter < rightHalf.Length)
                {
                    array[listCounter] = rightHalf[rightCounter];
                    listCounter++;
                    rightCounter++;
                }
            }
            return array;
        }
        static string[] Sort(string[] array)
        {
            if (array.Length > 1)
            {
                int mid = array.Length / 2;
                string[] leftHalf = new string[mid];
                string[] rightHalf = new string[array.Length - mid];
                for (int i = 0; i < mid; i++)
                    leftHalf[i] = array[i];
                for (int i = 0; i < array.Length - mid; i++)
                    rightHalf[i] = array[mid + i];
                Sort(leftHalf);
                Sort(rightHalf);
                int leftIndex = 0;
                int rightIndex = 0;
                int listIndex = 0;
                while (leftIndex < leftHalf.Length && rightIndex < rightHalf.Length)
                {
                    if (leftHalf[leftIndex].CompareTo(rightHalf[rightIndex]) <= 0)
                    {
                        array[listIndex] = leftHalf[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        array[listIndex] = rightHalf[rightIndex];
                        rightIndex++;
                    }
                    listIndex++;
                }
                while (leftIndex < leftHalf.Length)
                {
                    array[listIndex] = leftHalf[leftIndex];
                    listIndex++;
                    leftIndex++;
                }
                while (rightIndex < rightHalf.Length)
                {
                    array[listIndex] = rightHalf[rightIndex];
                    listIndex++;
                    rightIndex++;
                }
            }
            return array;
        }
    }
}
