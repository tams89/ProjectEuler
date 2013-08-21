using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// 10001st prime
    /// </summary>
    public class Euler7
    {
        public static void PrimeGenerator()
        {
            var potentialPrime = 0;
            var primesGenerated = 0;

            while (true)
            {
                potentialPrime++;

                if (!IsPrime(potentialPrime)) continue;

                primesGenerated++;
                Console.WriteLine(potentialPrime);
                if (primesGenerated == 10001) Console.ReadLine();
            }
        }

        public static bool IsPrime(int number)
        {
            var boundary = Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (var i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
