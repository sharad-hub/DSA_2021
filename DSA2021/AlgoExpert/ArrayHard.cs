using System;
using System.Linq;

namespace DSA2021.AlgoExpert
{
    public class ArrayHard
    {
        public static int MinRewards(int[] scores)
        {
            // Write your code here.
            //8,4,2,1,3,6,7,9,5 --> 4,3,2,1,2,3,4,5,1//

            //Find min max in seq 

            int[] rewards = new int[scores.Length];
            int localReward = 1;
            //Move forword

            if (scores.Length == 1)
                return 1;

            for (int i = 1; i < scores.Length; i++)
            {
                rewards[0] = 1;

                if (scores[i] > scores[i - 1])
                {
                    localReward++;
                    rewards[i] = localReward;
                }
                else
                {
                    localReward = 1;
                    rewards[i] = 1;
                }
            }


            // Move backword

            for (int i = scores.Length - 1; i > 0; i--)
            {
                if (scores[i] < scores[i - 1])
                {

                    rewards[i - 1] = Math.Max(rewards[i] + 1, rewards[i - 1]);
                }
            }

            return rewards.Sum();
        }
    }
}
