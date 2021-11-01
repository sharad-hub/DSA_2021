using DSA2021.AlgoExpert;
using DSA2021.EducativeIO;
using System;
using System.Collections.Generic;

namespace DSA2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList();
            //TwoPointers();
            // SlidingWindow();        


            Console.Read();
        }

        private static void SlidingWindow()
        {
            //var maxSum9 = PatternSlidingWindow.MaxSumViaSlidingWindow(new int[] { 2, 1, 5, 1, 3, 2 }, 3); //9
            //var maxSum7 = PatternSlidingWindow.MaxSumViaSlidingWindow(new int[] { 2, 3, 4, 1, 5 }, 2);  //7


            ///findMinSubArray(7, [2, 1, 5, 2, 3, 2])	2	-1	Incorrect Output
            ///findMinSubArray(7, [2, 1, 5, 2, 8]) 1 - 1  Incorrect Output
            ///findMinSubArray(8, [3, 4, 1, 1, 6]) 3
            ///
            // int minlength = PatternSlidingWindow.SmallestSubArrayForAgivenSum(new int[] { 2, 1, 5, 2, 3, 2 }, 7); //2
            // minlength = PatternSlidingWindow.SmallestSubArrayForAgivenSum(new int[] { 3, 4, 1, 1, 6 }, 8);  //3
            // minlength = PatternSlidingWindow.SmallestSubArrayForAgivenSum(new int[] { 2, 1, 5, 2, 8 }, 7);//1


            /*
            int count = PatternSlidingWindow.CountOccuranceOfAnagrams("forxxorfxdofr", "for");   //3

            int count2 = PatternSlidingWindow.CountOccuranceOfAnagrams("aabaabaa", "aaba");   //3


            int count3 = PatternSlidingWindow.CountOccuranceOfAnagrams("forxxorfxdofr", "aba");   //3

            int count4 = PatternSlidingWindow.CountOccuranceOfAnagrams("aabaabaa", "ab");   //3
            */




            //int LongestSubstingWithKDistinctChar

            /*
            int longestSubstringLength1 = PatternSlidingWindow.LongestSubstingWithKDistinctChar("araaci", 2); //4
            int longestSubstringLength2 = PatternSlidingWindow.LongestSubstingWithKDistinctChar("araaci", 1);  //2
            int longestSubstringLength3 = PatternSlidingWindow.LongestSubstingWithKDistinctChar("cbbebi", 3);//5

            */

            //same kind of toys

            //int count = PatternSlidingWindow.MaxToysOfTwoTypeInSequence("asaddddaabbbb");

            //int count2 = PatternSlidingWindow.MaxToysOfTwoTypeInSequence("abcddds");


            /*

            int count = PatternSlidingWindow.LengthOfLongestSubstringWithoutRepetation("aabccbb");  //3

            int count2 = PatternSlidingWindow.LengthOfLongestSubstringWithoutRepetation("abbbb");  //2

            int count3 = PatternSlidingWindow.LengthOfLongestSubstringWithoutRepetation("abccdef"); //4

            */


            /*
            int count = PatternSlidingWindow.LengthOfLongestSubstringWithRepetationAnd_K_Replacement("aabccbb", 2);  //5

            int count2 = PatternSlidingWindow.LengthOfLongestSubstringWithRepetationAnd_K_Replacement("abbcb", 1);  //4

            int count3 = PatternSlidingWindow.LengthOfLongestSubstringWithRepetationAnd_K_Replacement("abccde", 1); //3
            */

            /*
             var pair1 = PatternTwoPointers.GetPairWithSum(new int[] { 1, 2, 3, 4, 6 }, 6);  //1,3

             var pair2 = PatternTwoPointers.GetPairWithSum(new int[] { 2, 5, 9, 11 }, 11);  //0,2

             //var pair3 = PatternTwoPointers.GetPairWithSum(new int[] { 1, 2, 3, 4, 6 }, 6);  //1,3
             */

            /*
            var index1 = PatternTwoPointers.RemoveDuplicates(new int[] { 1, 2, 2, 4, 5,5,6 });  //1,2,4,5,6

            var index2 = PatternTwoPointers.RemoveDuplicates(new int[] { 1, 2, 3, 4, 5,5,6 });  //1,2,3,4,5,6

            var index3 = PatternTwoPointers.RemoveDuplicates(new int[] { 1, 2, 3, 4, 5, 6 });  //1,2,3,4,5,6
            */

            /*
            

            var list1 = ArrayMedium.ThreeNumberSum(new int[] { 1, 2, 3 }, 6);
            var list2 = ArrayMedium.ThreeNumberSum(new int[] { 12, 3, 1, 2, -6, 5, 0, -8, -1 }, 0);
            var list3 = ArrayMedium.ThreeNumberSum(new int[] { 12, 3, 1, 2, -6, 5, 0, -8, -1, 6, -5 }, 0);
            //var list4 = ArrayMedium.ThreeNumberSum(new int[] { 1, 2, 3 }, 6);
            //var list5 = ArrayMedium.ThreeNumberSum(new int[] { 1, 2, 3 }, 6);
 */


            var list1 = ArrayMedium.SmallestDifference(new int[] { -1, 5, 10, 20, 28, 3 }, new int[] { 26, 134, 135, 15, 17 });


            /*
            var list2 = ArrayMedium.SmallestDifference(new int[] { -1, 5, 10, 20, 3 }, new int[] { 26, 134, 135, 15, 17 });

            var list3 = ArrayMedium.SmallestDifference(new int[] { 1, 5, 10, 20, 28, 3 }, new int[] { 1, 5, 10, 20, 28, 3 });

            */



            var rew1 = ArrayHard.MinRewards(new int[] { 8, 4, 2, 1, 3, 6, 7, 9, 5 }); //25

            var rew2 = ArrayHard.MinRewards(new int[] { 2, 1, 4, 3, 6, 5, 8, 7, 10, 9 }); //15


        }

        private static void TwoPointers()
        {
            //
            int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            int totalSum = 10;
            ArrayEasy.TwoNumberSum(array, totalSum);


            int[] array2 = new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            // var response = PatternSlidingWindow.AverageOfSubArrayOfSizeViaSlidingWindow(array2, 5);

            var result = ArrayEasy.SortedSquaredArrayUsingPointers(new int[] { -10,-3,-2,0,1,3,5,8,9 });


            // bool value = ArrayEasy.IsValidSubsequence(new System.Collections.Generic.List<int> { 5, 1, 22, 3, 4, 5 }, new System.Collections.Generic.List<int> { 3, 4, 8 });


            List<List<string>> list = new List<List<string>>
              {
                 new List<string> {"HTML", "C#" }
                 //,
                 // new List<string> {"C#", "Python" },
                 //  new List<string> { "Python", "HTML" }
              };
            //List<int> results = new List<int> { 0, 0, 1 };
            List<int> results = new List<int> { 1 };

            string winner = ArrayEasy.TournamentWinner(list, results);
        }

        private static void LinkedList()
        {

            //LinkedList list= new LinkedList(1);
            //list.next = new LinkedList(1);
            //list.next.next= new LinkedList(2);
            //list.next.next.next = new LinkedList(2);
            //list.next.next.next = new LinkedList(4);
            //list.next.next.next.next = new LinkedList(5);

            LinkedList list = new LinkedList(1);
            list.next = new LinkedList(1);
            list.next.next = new LinkedList(1);
            list.next.next.next = new LinkedList(3);
            list.next.next.next = new LinkedList(4);
            list.next.next.next.next = new LinkedList(4);
            list.next.next.next.next.next = new LinkedList(4);
            list.next.next.next.next.next.next = new LinkedList(5);
            list.next.next.next.next.next.next.next = new LinkedList(6); 
            list.next.next.next.next.next.next.next.next = new LinkedList(6);



            var list2= LinkedLiskEasy.RemoveDuplicatesFromLinkedList(list);
        }
    }
}
