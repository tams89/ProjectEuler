using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// Summation of primes
    /// </summary>
    public class Euler10
    {
        // Find the sum of all the primes below two million.
        public static void SummationOfPrimesBelowTwoMillion()
        {
            //int sumOfPrimes = 0;
            //var primes = Primes((int)2e6);
            //foreach (var prime in primes)
            //{
            //    sumOfPrimes += prime;
            //}

            int sumOfPrimes = 0;
            foreach (var prime in PrimeGenerator())
            {
                sumOfPrimes += prime;
            }

            Console.WriteLine("Sum of primes below two million = {0}", sumOfPrimes);
            Console.ReadLine();
        }

        private static IEnumerable<int> PrimeGenerator()
        {
            var oneToTwoMillion = Enumerable.Range(1, ((int)2e6));
            var primesOnly = oneToTwoMillion.Where(IsPrime).AsParallel().ToArray();
            return primesOnly;
        }

        private static bool IsPrime(int potentialPrime)
        {
            // Exceptions.
            if (potentialPrime == 1) return false;
            if (potentialPrime == 2 || potentialPrime == 3 || potentialPrime == 5 || potentialPrime == 7) return true;

            var listOfRandomNums = new int[100];
            var random = new Random(potentialPrime);
            for (var i = 0; i < listOfRandomNums.Length; i++)
            {
                listOfRandomNums[i] = random.Next(1, potentialPrime);
            }

            return listOfRandomNums.AsParallel().Select(listOfRandomNum => Math.Pow(listOfRandomNum, (potentialPrime - 1))).Any(a => Math.Abs(a - 1) < 0.001);
        }

        private static IEnumerable<int> Primes(int maximusPrime)
        {
            var vals = new List<int>((int)(maximusPrime / (Math.Log(maximusPrime) - 1.08366)));
            var maxSquareRoot = Math.Sqrt(maximusPrime);
            var eliminated = new BitArray(maximusPrime + 1);

            vals.Add(2);

            for (int i = 3; i <= maximusPrime; i += 2)
            {
                if (eliminated[i]) continue;
                
                if (i < maxSquareRoot)
                {
                    for (var j = i * i; j <= maximusPrime; j += 2 * i)
                    {
                        eliminated[j] = true;
                    }
                }

                vals.Add(i);
            }

            return vals;
        }
    }
}
