using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// What is the value of the first triangle number to have over five hundred divisors?
    /// </summary>
    public class Euler12
    {
        public static long FirstTriangleNumberWith500Divisors()
        {
            long valueWithMostDivisorsSoFar = 0;
            long numberOfDivisors = 0;
            long incrementor = (int)1e3;

            for (long i = 1; ; i += incrementor)
            {
                var num = TriangleNumberGen(i);
                var divisors = HasNumOfDivisors(num, 500);

                if (divisors > numberOfDivisors)
                {
                    numberOfDivisors = divisors;
                    valueWithMostDivisorsSoFar = num;

                    Console.WriteLine("Value: {0}, divisors: {1}", valueWithMostDivisorsSoFar, divisors);
                }

                if (divisors > 450) incrementor = 1;
                if (divisors > 500) break;
            }

            return valueWithMostDivisorsSoFar;
        }

        private static long TriangleNumberGen(long triangleNumberPosition)
        {
            long triangleNumber = 0;
            Parallel.For(1, triangleNumberPosition, x =>
            {
                triangleNumber += x;
            });

            return triangleNumber + triangleNumberPosition;
        }

        private static long HasNumOfDivisors(long triangleNum, long numberOfDivisors)
        {
            long divisors = 0;
            Parallel.For(1, triangleNum, x =>
            {
                if (!Euler7.IsPrime(triangleNum))
                {
                    if (triangleNum % x == 0)
                        divisors++;
                }
            });

            return divisors;
        }
    }
}
