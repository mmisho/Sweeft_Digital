using System;

namespace MinCoins
{
    class Program
    {
        static void Main(string[] args)
        {
           int steps = int.Parse(Console.ReadLine());
           int countWays=CountVariants(steps);
            Console.WriteLine($"There are {countWays} different ways to stand on {steps} stair");
        }
        static int CountVariants(int stairCount)
        {
            int countWays=0;
            int[] lastTwoSteps = new int[] { 1, 2 }; //წინა ორ საფეხურზე მოსვლის გზების რაოდენობა;
            if (stairCount == 1)
            {
                countWays = lastTwoSteps[0];
            }
            else if(stairCount == 2)
            {
                countWays=lastTwoSteps[1];
            }
            else
            {
                for(int i = 3; i <= stairCount; i++)
                {
                    countWays = lastTwoSteps[0] + lastTwoSteps[1];
                    lastTwoSteps[0] = lastTwoSteps[1];
                    lastTwoSteps[1] = countWays;

                }
            }
            return countWays;
        }
   
    }
}
