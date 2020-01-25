using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main()
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> mixedNumbers = new List<int>();

            int rangeA;
            int rangeB;
            bool biggerFirst = false;
            bool biggerSecond = false;
            if (firstNumbers.Count > secondNumbers.Count)
            {
                biggerFirst = true;
                rangeA = firstNumbers[firstNumbers.Count - 1];
                rangeB = firstNumbers[firstNumbers.Count - 2];
                firstNumbers.RemoveAt(firstNumbers.Count - 1);
                firstNumbers.RemoveAt(firstNumbers.Count - 1);
            }
            else
            {
                biggerSecond = true;
                rangeA = secondNumbers[secondNumbers.Count - 1];
                rangeB = secondNumbers[secondNumbers.Count - 2];
                secondNumbers.RemoveAt(secondNumbers.Count - 1);
                secondNumbers.RemoveAt(secondNumbers.Count - 1);
            }

            for (int i = 0; i < firstNumbers.Count; i++)
            {
                int currentFirst = 0;
                int currentSecond = 0;
                if (biggerFirst)
                {
                    currentFirst = firstNumbers[i];
                    currentSecond = secondNumbers[secondNumbers.Count - 1 - i];
                }
                else if (biggerSecond)
                {
                    currentFirst = secondNumbers[i];
                    currentSecond = firstNumbers[firstNumbers.Count - 1 - i];
                }

                mixedNumbers.Add(currentFirst);
                mixedNumbers.Add(currentSecond);
            }

            int smaller = rangeA;
            int bigger = rangeB;
            if (rangeA > rangeB)
            {
                smaller = rangeB;
                bigger = rangeA;
            }

            List<int> outputList = new List<int>();
            for (int i = 0; i < mixedNumbers.Count; i++)
            {
                int currentNumber = mixedNumbers[i];
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
