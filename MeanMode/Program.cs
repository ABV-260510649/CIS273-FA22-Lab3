using System;
using System.Collections.Generic;

namespace MeanMode
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 0, 0, 3, 3, 3, -3, -3, -3, };

            Console.WriteLine( (MeanMode(numbers)));
        }

        public static bool MeanMode(int[] array)
        {
            return computeMode(array) == computeAverage(array);
        }

        // TODO
        private static double computeAverage(int[] array)
        {
            double average = 0;
            foreach (var num in array)
            {
                average += num;
            }
            return average / array.Length;
        }

        // TODO
        private static double? computeMode(int[] array)
        {
            var numCounts = new Dictionary<int, int>();
            foreach (var num in array)
            {
                if (numCounts.ContainsKey(num))
                {
                    numCounts[num]++;
                }
                else
                {
                    numCounts.Add(num, 1);
                }
            }

            KeyValuePair<int, int> mode = new KeyValuePair<int, int>();
            foreach (var num in numCounts)
            {
                if (num.Value >= mode.Value)
                {
                    mode = num;
                }
            }

            return mode.Key;
        }
    }
}
