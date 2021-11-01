using System;

namespace DSA2021.EducativeIO
{
    public class PatternTwoPointers
    {


        public static Tuple<int, int> GetPairWithSum(int[] sorterArray, int sum)
        {
            int left = 0;
            int right = sorterArray.Length - 1;

            while (left < right)
            {
                int targetSum = sorterArray[left] + sorterArray[right];
                if (targetSum == sum)
                    return new Tuple<int, int>(left, right);



                if (targetSum > sum)
                    right--;
                else
                    left++;


            }

            return new Tuple<int, int>(-1, -1);

        }



        //without any extra space
        public static int RemoveDuplicates(int[] sorterArray)
        {
            int nonDuplicateNumber = 0;
            // 1,2,2,3,4,4,5

            int lastUniqueElementIndex = 1;

            for (int i = 1; i < sorterArray.Length; i++)
            {
                if (sorterArray[i] != sorterArray[lastUniqueElementIndex-1])
                {
                    sorterArray[lastUniqueElementIndex] = sorterArray[i];
                    lastUniqueElementIndex++;
                }
            }
            return lastUniqueElementIndex;
        }
    }
}
