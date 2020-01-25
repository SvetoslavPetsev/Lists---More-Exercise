using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main()
        {
            List<double> firstNumbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            List<double> secondNumbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            List<double> mixedNumbers = new List<double>();

            double rangeA;
            double rangeB;

            if (firstNumbers.Count > secondNumbers.Count)
            {
                rangeA = firstNumbers[firstNumbers.Count - 1];
                rangeB = firstNumbers[firstNumbers.Count - 2];
                firstNumbers.RemoveRange(firstNumbers.Count - 2, 2);
            } 
            else
            {
                rangeA = secondNumbers[0];
                rangeB = secondNumbers[1];
                secondNumbers.RemoveRange(0,2);
            }

            for (int i = 0; i < firstNumbers.Count; i++)
            {
                double currentFirst = firstNumbers[i];
                double currentSecond = secondNumbers[secondNumbers.Count - 1 - i];
                mixedNumbers.Add(currentFirst);
                mixedNumbers.Add(currentSecond);
            }

            double smaller = rangeA;
            double bigger = rangeB;
            if (rangeA > rangeB)
            {
                smaller = rangeB;
                bigger = rangeA;
            }

            List<double> outputList = new List<double>();
            for (int i = 0; i < mixedNumbers.Count; i++)
            {
                double currentNumber = mixedNumbers[i];
                if (currentNumber > smaller && currentNumber < bigger)
                {
                    outputList.Add(currentNumber);
                }
            }
            outputList.Sort();
            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
