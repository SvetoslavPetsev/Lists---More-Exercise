using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Messaging
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(" ")
                .ToList();
            List<char> text = Console.ReadLine().ToList();

            List<char> hiddenMassage = new List<char>();

            for (int i = 0; i < input.Count; i++)
            {
                string number = input[i];
                int sumOfElements = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    string temp = number[j].ToString();
                    int element = int.Parse(temp);
                    sumOfElements += element;
                }

                int indexToCollect = sumOfElements;

                while (indexToCollect > text.Count - 1)
                {
                    indexToCollect -= text.Count;
                }

                hiddenMassage.Add(text[indexToCollect]);
                text.RemoveAt(indexToCollect);
            }
            Console.WriteLine(string.Join("", hiddenMassage));
        }
    }
}
