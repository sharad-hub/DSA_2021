using System;

using System.Collections.Generic;

namespace DSA2021.AlgoExpert
{
    public class ArrayEasy
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            int[] numbers = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                    {
                        if (array[i] + array[j] == targetSum)
                        {
                            numbers[0] = array[i];
                            numbers[1] = array[j];
                            return numbers;
                        }
                    }
                }
            }
            return new int[0];
        }

        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int index = 0;
            foreach (int x in array)
            {

                if (index <= sequence.Count && x == sequence[index])
                {
                    index++;
                }
                //else
                //{
                //    index = 0;
                //}
                if (index == sequence.Count)
                    return true;
            }

            return false;
        }


        public int[] SortedSquaredArray(int[] array)
        {
            // Write your code here.
            int[] sortedSquarArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int val = array[i];
                sortedSquarArray[i] = val * val;
            }
            Array.Sort(sortedSquarArray);
            return sortedSquarArray;
        }


        public static int[] SortedSquaredArrayUsingPointers(int[] array)
        {
            // Write your code here.
            int[] sortedSquarArray = new int[array.Length-1];
 
            int i = 0;
            int j = array.Length-1;
            int index= array.Length - 1;
            while (i < j)
            {
                if (array[i] * array[i] > array[j] * array[j])
                {
                    sortedSquarArray[index] = array[i] * array[i];
                    i++;
                }
                else
                {
                    sortedSquarArray[index] = array[j] * array[j];
                    j--;
                }

                index--;
            }

            return sortedSquarArray;
        }





        public int[] SortedSquaredArrayWithoutBuiltInFunction(int[] array)
        {
            // Write your code here.
            int[] sortedSquarArray = new int[array.Length];

            int nexgativeIndex = 0;
            int postiveIndex = array.Length - 1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int smallValue = array[nexgativeIndex]; int largeValue = array[postiveIndex];
                if (Math.Abs(largeValue) < Math.Abs(smallValue))
                {

                    sortedSquarArray[i] = smallValue * smallValue;
                    nexgativeIndex++;
                }
                else
                {
                    sortedSquarArray[i] = largeValue * largeValue; postiveIndex--;
                }
                postiveIndex--;

                //int val = array[i];
                //sortedSquarArray[i] = val * val;
            }

            return sortedSquarArray;
        }


        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.
            string winner = "";
            int winnerCount = 0;

            Dictionary<string, int> winData = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {

                if (results[i] == 0)
                {
                    int count = 0;
                    string awayTeam = competitions[i][1];

                    if (winData.TryGetValue(awayTeam, out count))
                    {
                        count++;
                        if (winnerCount < count)
                        {
                            winnerCount = count;
                            winner = awayTeam;
                        }
                    }
                    if (winnerCount == 0)
                    {
                        winner = awayTeam;
                    }
                    winData[awayTeam] = count;

                }
                else
                {
                    string homeTeam = competitions[i][0];
                    int count = 0;
                    if (winData.TryGetValue(homeTeam, out count))
                    {
                        count++;
                        if (winnerCount < count)
                        {
                            winnerCount = count;
                            winner = homeTeam;
                        }
                    }
                    winData[homeTeam] = count;
                    if (winnerCount == 0)
                    {
                        winner = homeTeam;
                    }
                }
            }
            return winner;
        }
    }
}


