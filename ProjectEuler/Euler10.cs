using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
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
            int sumOfPrimes = 0;
            var primes = Sieve2((int)2e6);
            foreach (var prime in primes)
            {
                sumOfPrimes += prime;
            }

            Console.WriteLine("Sum of primes below two million = {0}", sumOfPrimes);
            Console.ReadLine();
        }


        private static IEnumerable<int> Primes(int maximumPrime)
        {
            // HashSet pre-populated with initial values. Also HashSet inherently only allows unique values and all primes are unique.
            var primes = new HashSet<int> { 2, 3, 5, 7 };

            // Exclusion bit array, all values false by default.
            var exclude = new BitArray(maximumPrime + 1);

            // For the testing of the trial division 
            var sqrtOfMax = Math.Ceiling(Math.Sqrt(maximumPrime));

            // Increment in steps of 2 starting from 3 as all even numbers are multiples of 2 and are not primes; so these are 
            // avoided by incrementing 3 (odd) by an even number 2 which is always odd.
            for (var i = 3; i <= maximumPrime; i += 2)
            {
                // If in exclusion list goto next value. 
                if (exclude[i]) continue;
                
                if (i <= sqrtOfMax)
                    // A prime squared is not a prime
                    // Exclude all multiples of this prime; 2 * primeSquared which are even and so cannot be prime except for 2.
                    for (var j = i * i; j <= maximumPrime; j += 2 * i)
                        exclude[j] = true;

                // If not excluded and not a multiple of a primeSquared then is a prime.
                primes.Add(i);
            }

            return primes;
        }
    }
}
