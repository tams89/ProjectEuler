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
            sw.Start();
            var res = Euler12.FirstTriangleNumberWith500Divisors();
            sw.Stop();
            TotalTime(sw.ElapsedMilliseconds, res.ToString());
        }

        private static void TotalTime(long timeTaken, string result)
        {
            Console.WriteLine("Time elapsed: {0}, result: {1}", timeTaken, result);
        }
    }
}