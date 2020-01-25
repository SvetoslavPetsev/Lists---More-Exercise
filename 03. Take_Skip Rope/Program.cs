using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main()
        {
            string hiddenMassage = Console.ReadLine();

            List<int> numbersInput = new List<int>();
            List<char> textInput = new List<char>();

            for (int i = 0; i < hiddenMassage.Length; i++)
            {
                char currentSymbol = hiddenMassage[i];

                if (currentSymbol >= 48 && currentSymbol <= 57)
                {
                    string temp = currentSymbol.ToString();
                    int number = int.Parse(temp);
                    numbersInput.Add(number);
                }
                else
                {
                    textInput.Add(currentSymbol);
                }
            }

            List<int> takeList = new List<int>(); //even
            List<int> skipList = new List<int>(); //odd

            for (int j = 0; j < numbersInput.Count; j++)
            {
                if (j % 2 == 0)
                {
                    takeList.Add(numbersInput[j]);
                }
                else
                {
                    skipList.Add(numbersInput[j]);
                }
            }
            string result = "";
            int skipAll = 0;

            for (int i = 0; i < skipList.Count; i++)
            {
                int count = skipAll + takeList[i];
                for (int j = skipAll; j < count; j++)
                {
                    if (j > textInput.Count - 1)
                    {
                        break;
                    }
                    char symbol = textInput[j];
                    result += symbol;
                }
                skipAll += takeList[i] + skipList[i];
            }

            Console.WriteLine(result);
        }
    }
}
