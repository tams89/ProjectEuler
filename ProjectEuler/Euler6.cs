using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// Sum square difference
    /// </summary>
    public class Euler6
    {
        public static void SumSquareDifference()
        {
            Result();
        }

        static IEnumerable<int> OneToAHundred()
        {
            for (int q = 1; q <= 100; q++)
            {
                yield return q;
            }
        }

        static IEnumerable<int> SquareEachAndSum()
        {
            yield return OneToAHundred()
                .Select(num => (int)Math.Pow(num, 2)).Sum();
        }

        static IEnumerable<int> Sum()
        {
            yield return (int)Math.Pow(OneToAHundred().Sum(), 2);
        }


        static void Result()
        {
            var diffBetweenSumOfSquareAndSquareOfSum =
                (SquareEachAndSum().Single() - Sum().Single());

            Console.WriteLine(Math.Abs(diffBetweenSumOfSquareAndSquareOfSum));
            Console.Read();
        }
    }
}
