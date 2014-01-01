using System.Globalization;

namespace ProjectEuler
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The sw.
        /// </summary>
        private static readonly Stopwatch sw = new Stopwatch();

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            sw.Start();
            var res = new Euler26().Answer();
            sw.Stop();
            TotalTime(sw.ElapsedMilliseconds, res.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// The total time.
        /// </summary>
        /// <param name="timeTaken">
        /// The time taken.
        /// </param>
        /// <param name="result">
        /// The result.
        /// </param>
        private static void TotalTime(long timeTaken, string result)
        {
            Console.WriteLine("Time elapsed: {0}, result: {1}", timeTaken, result);
            Console.ReadLine();
        }
    }
}