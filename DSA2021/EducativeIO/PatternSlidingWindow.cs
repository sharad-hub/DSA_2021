using System;
using System.Collections.Generic;

namespace DSA2021.EducativeIO
{
    public class PatternSlidingWindow
    {
        public static double[] AverageOfSubArrayOfSizeK(int[] array, int size)
        {
            int length = array.Length;

            int index = 0;
            double[] output = new double[size];
            int startElement = array[0];
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + array[i];
            }
            output[0] = (double)sum / size;
            while ((index + size) < length)
            {
                sum = sum + array[index + size] - startElement;

                index++;

                output[index] = (double)sum / size;
                startElement = array[index];
            }

            Console.WriteLine(output.ToJsonStirng());
            return output;
        }
        public static double[] AverageOfSubArrayOfSizeViaSlidingWindow(int[] array, int size)
        {
            int windowStart = 0;
            //int windowEnd=0;
            int windowSum = 0;
            double[] output = new double[array.Length - size + 1];

            for (int windowEnd = 0; windowEnd < array.Length; windowEnd++)
            {
                windowSum += array[windowEnd];

                if (windowEnd >= size - 1)
                {
                    output[windowStart] = (double)windowSum / size;
                    windowSum -= array[windowStart];
                    windowStart++;
                }
            }
            Console.WriteLine(output.ToJsonStirng());

            return output;


        }

        public static int MaxSumViaSlidingWindow(int[] array, int size)
        {
            int maxSum = 0;
            int windowSum = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < array.Length - 1; windowEnd++)
            {
                windowSum += array[windowEnd];

                if (windowEnd >= size - 1)
                {
                    if (windowSum > maxSum)
                        maxSum = windowSum;

                    // slide window

                    windowSum -= array[windowStart];
                    windowStart++;
                }
            }
            return maxSum;
        }

        public static int SmallestSubArrayForAgivenSum(int[] array, int sum)
        {
            int smallestArrayLength = int.MaxValue;

            int windowSum = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < array.Length; windowEnd++)
            {
                windowSum += array[windowEnd];
                //shrink window
                while (windowSum >= sum)
                {


                    //int windowLength = windowEnd - windowStart;
                    //if (windowLength < smallestArrayLength)
                    smallestArrayLength = Math.Min(smallestArrayLength, windowEnd - windowStart + 1);
                    windowSum -= array[windowStart];
                    windowStart++;

                }
            }
            return smallestArrayLength;



        }



        /// <summary>
        ///Problem Statement #
        ///Given a string, find the length of the longest substring in it with no more than K distinct characters.
        ///
        ///Example 1:
        ///Input: String= "araaci", K= 2
        ///Output: 4
        ///Explanation: The longest substring with no more than '2' distinct characters is "araa".
        ///
        ///Example 2:
        ///Input: String= "araaci", K= 1
        ///Output: 2
        //Explanation: The longest substring with no more than '1' distinct characters is "aa".
        /// </summary>
        /// <returns></returns>
        public static int LongestSubstingWithKDistinctChar(string str, int k)
        {
            //int substringLength = 0;
            Dictionary<char, int> keyValues = new Dictionary<char, int>();
            int winStart = 0;
            int maxLength = -1;
            // int currentWinCount = 0;
            for (int winEnd = 0; winEnd < str.Length; winEnd++)
            {

                if (keyValues.ContainsKey(str[winEnd]))
                {
                    keyValues[str[winEnd]] = keyValues[str[winEnd]] + 1;
                }
                else
                {
                    keyValues[str[winEnd]] = 1;
                    //currentWinCount++;
                }
                while (keyValues.Count > k)
                {// slide the window

                    keyValues[str[winStart]] = keyValues[str[winEnd]] - 1;

                    if (keyValues[str[winStart]] == 0)
                    {
                        keyValues.Remove(str[winStart]);
                        // currentWinCount--;
                    }
                    winStart++;
                }
                maxLength = Math.Max(maxLength, winEnd - winStart + 1);

            }
            return maxLength;

        }


        private static Dictionary<char, int> RefilKeys(string str)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();


            foreach (var item in str)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item] = keyValuePairs[item] + 1;
                }
                else
                {
                    keyValuePairs[item] = 1;
                }
            }

            return keyValuePairs;
        }

        public static int CountOccuranceOfAnagrams(string str, string substr)
        {
            int k = substr.Length;
            Dictionary<char, int> keyValuePairs = RefilKeys(substr);


            Dictionary<char, int> currentChars = keyValuePairs;
            int windowStart = 0;
            int currentWindowCharCount = 0;
            int resultCount = 0;
            int countOfMap = currentChars.Count;
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                if (currentChars.ContainsKey(str[windowEnd]))
                {

                    currentChars[str[windowEnd]] = currentChars[str[windowEnd]] - 1;

                    if (currentChars[str[windowEnd]] == 0)
                    {
                        countOfMap--;
                    }


                    //currentWindowCharCount++;

                }


                if ((windowEnd - windowStart + 1) == k)
                {
                    if (countOfMap == 0)
                    {
                        resultCount++;
                    }

                    //
                    if (currentChars.ContainsKey(str[windowStart]))
                    {
                        currentChars[str[windowStart]] = currentChars[str[windowStart]] + 1;

                        if (currentChars[str[windowStart]] == 1)
                        {
                            countOfMap++;
                        }
                    }

                    windowStart++;
                }
            }
            return resultCount;
        }


        public static int MaxToysOfTwoTypeInSequence(string arr)
        {
            int k = 2;
            Dictionary<char, int> keyValues = new Dictionary<char, int>();

            int windowStart = 0;
            int maxLength = 0;
            int currentWindowSum = 0;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                if (keyValues.ContainsKey(arr[windowEnd]))
                {
                    keyValues[arr[windowEnd]]++;
                    currentWindowSum++;
                }
                else
                {
                    // firsttime
                    keyValues[arr[windowEnd]] = 1;
                    currentWindowSum++;
                }

                // shrink window

                while (keyValues.Count > 2)
                {
                    // slide the window
                    keyValues[arr[windowStart]]--;

                    if (keyValues[arr[windowStart]] == 0)
                        keyValues.Remove(arr[windowStart]);

                    windowStart++;

                }
                maxLength = Math.Max(maxLength, (windowEnd - windowStart + 1));

            }
            return maxLength;
        }

        public static int LengthOfLongestSubstringWithoutRepetation(string str)
        {
            int windStart = 0;
            int lengthOfSubsting = 0;
            Dictionary<char, int> keyValues = new Dictionary<char, int>();
            int windowCount = 0;
            for (int winEnd = 0; winEnd < str.Length; winEnd++)
            {
                if (keyValues.ContainsKey(str[winEnd]))
                {
                    keyValues[str[winEnd]]++;
                }
                else
                {
                    keyValues[str[winEnd]] = 1;
                }
                windowCount++;
                while (windowCount > keyValues.Count)
                {
                    keyValues[str[windStart]]--;
                    windowCount--;
                    if (keyValues[str[windStart]] == 0)
                    {
                        keyValues.Remove(str[windStart]);
                    }

                    windStart++;
                }
                lengthOfSubsting = Math.Max(lengthOfSubsting, (winEnd - windStart + 1));

            }

            return lengthOfSubsting;
        }


        public static int LengthOfLongestSubstringWithRepetationAnd_K_Replacement(string str, int k)
        {
            int windStart = 0;
            int lengthOfSubsting = 0;
            Dictionary<char, int> keyValues = new Dictionary<char, int>();
            int maxRepetitionCount = 0;
            for (int winEnd = 0; winEnd < str.Length; winEnd++)
            {
                if (keyValues.ContainsKey(str[winEnd]))
                {
                    keyValues[str[winEnd]]++;

                    maxRepetitionCount = Math.Max(maxRepetitionCount, keyValues[str[winEnd]]);
                }
                else
                {
                    keyValues[str[winEnd]] = 1;
                }


                while ((winEnd - windStart + 1) - maxRepetitionCount > k)
                {
                    //
                    keyValues[str[windStart]]--;
                    if (keyValues[str[windStart]] == 0)
                    {
                        keyValues.Remove(str[windStart]);
                    }

                    windStart++;
                }
                lengthOfSubsting = Math.Max(lengthOfSubsting, (winEnd - windStart + 1));

            }

            return lengthOfSubsting;
        }

    }
}
