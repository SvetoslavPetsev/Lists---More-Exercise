using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Car_Race
{
    class Program
    {
        static void Main()
        {
            List<int> race = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int finishIndex = race.Count / 2;

            List<int> leftRacer = new List<int>();
            List<int> rightRacer = new List<int>();

            for (int i = 0; i < finishIndex; i++)
            {
                leftRacer.Add(race[i]);
            }

            for (int i = race.Count - 1; i > finishIndex; i--)
            {
                rightRacer.Add(race[i]);
            }

            double sumLeftRacer = GetSumOfTime(leftRacer);
            double sumRightRacer = GetSumOfTime(rightRacer);

            if (sumLeftRacer <= sumRightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeftRacer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumRightRacer}");
            }
        }

        private static double GetSumOfTime(List<int> times)
        {
            double sumTimes = 0.0;

            for (int i = 0; i < times.Count; i++)
            {
                double currentTime = times[i];

                if (currentTime == 0)
                {
                    sumTimes = sumTimes * 8 / 10 ;
                }
                else
                {
                    sumTimes += currentTime;
                }
            }
            return sumTimes;
        }
    }
}
