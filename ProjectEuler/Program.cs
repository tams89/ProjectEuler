using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        private static Stopwatch sw = new Stopwatch();

        public static void Main(string[] args)
        {
            var res = Euler11.GreatestFourAdjacentNumbers();
            Console.WriteLine(res);
        }

        private static void TotalTime(long timeTaken, string problem, dynamic result)
        {
            Console.WriteLine("Time elapsed: {0}. Problem: {1}. Result: {2}", timeTaken, problem, result.ToString());
        }
    }
}