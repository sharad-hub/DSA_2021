using System;
using System.Collections;

using System.Collections.Generic;

namespace DSA2021.AlgoExpert
{

    public class ArrayMedium
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            // 1,2,4,5,6,7,8,9
            List<int[]> triplets = new List<int[]>();
            Array.Sort(array, Comparer.Default);



            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;

                while (left < right)
                {
                    int currentSum = array[left] + array[right] + array[i];

                    if (currentSum == targetSum)
                    {
                        triplets.Add(new int[] { array[i], array[left], array[right] });
                    }

                    if (currentSum > targetSum)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }

                }
            }


            return triplets;
        }


        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            //Sort arrays
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int[] smallestPair = new int[] { };
            int firstPtr = 0;
            int secondPtr = 0;
            int smallestDiff = int.MaxValue;

            int currentDiff = int.MaxValue;
            while (firstPtr < arrayOne.Length && secondPtr < arrayTwo.Length)
            {
                int firstNum = arrayOne[firstPtr];
                int secondNum = arrayTwo[secondPtr];

                if (firstNum - secondNum == 0)
                {
                    return new int[] { firstNum, secondNum };
                }



                if (firstNum > secondNum)
                {
                    currentDiff = firstNum - secondNum;
                    secondPtr++;
                }
                else
                {
                    currentDiff = secondNum - firstNum;
                    firstPtr++;
                }

                if (currentDiff < smallestDiff)
                {
                    smallestDiff = currentDiff;
                    smallestPair = new int[] { firstNum, secondNum };
                }
            }

            return smallestPair;
        }

        /// <summary>
        ///   
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int FirstDuplicateValue_UsingHash(int[] array)
        {   
           Dictionary<int,int> keyValues = new Dictionary<int, int>() ;

            for (int i = 0; i < array.Length; i++)
            {
                if(keyValues.ContainsKey(array[i]))
                    return i;
                else
                {
                    keyValues.Add(array[i],1);
                }
            }            
            return -1;
        }
    }
}


