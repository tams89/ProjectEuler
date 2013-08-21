using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler3
    {
        public static void FindGreatestPrimeFactor()
        {
            var factor = FindGreatestPrimeFactor(1, 600851475143);
            Console.WriteLine(factor);
            Console.Read();
        }

        private static long FindGreatestPrimeFactor(long factorGreaterThan, long number)
        {
            var upperBound = (long)Math.Ceiling(Math.Sqrt(number));

            //find next factor of the number
            var nextFactor = Range(factorGreaterThan + 1, upperBound)
                .SkipWhile(x => number % x > 0).FirstOrDefault();

            //if no other factor found then number must be prime.
            if (nextFactor == 0)
            {
                return number;
            }
            else
            {
                //find the multiplicity of the factor.
                long multiplicity = Enumerable.Range(1, Int32.MaxValue).
                    TakeWhile(i => number % (long)Math.Pow(nextFactor, i) == 0).Last();

                long quotient = number / (long)Math.Pow(nextFactor, multiplicity);

                if (quotient == 1)
                {
                    return nextFactor;
                }
                
                return FindGreatestPrimeFactor(nextFactor, quotient);
            }
        }

        private static IEnumerable<long> Range(long first, long last)
        {
            for (var i = first; i <= last; i++)
            {
                yield return i;
            }
        }
    }
}
