using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Drum_Set
{
    class Program
    {
        static void Main()
        {
            double startMoney = double.Parse(Console.ReadLine());

            List<int> drumSetStart = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> drumSetActual = new List<int>();
            for (int i = 0; i < drumSetStart.Count; i++)
            {
                drumSetActual.Insert(i, drumSetStart[i]);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }

                int hitPower = int.Parse(input);

                for (int i = 0; i < drumSetActual.Count; i++)
                {
                    if (drumSetActual[i] - hitPower < 0)
                    {
                        drumSetActual[i] = 0;
                        continue;
                    }
                    else
                    {
                        drumSetActual[i] -= hitPower;
                    }
                }
                if (drumSetActual.Contains(0))
                {
                    for (int i = 0; i < drumSetActual.Count; i++)
                    {
                        if (drumSetActual[i] == 0)
                        {
                            if (startMoney - drumSetStart[i] * 3.0 >= 0)
                            {
                                drumSetActual[i] = drumSetStart[i];
                                startMoney -= drumSetStart[i] * 3.0;
                            }
                            else
                            {
                                drumSetActual.RemoveAt(i);
                                drumSetStart.RemoveAt(i);
                            }
                        }
                    }
                } 
            }
            Console.WriteLine(string.Join(" ", drumSetActual));
            Console.WriteLine($"Gabsy has {startMoney:F2}lv.");
        }
    }
}
