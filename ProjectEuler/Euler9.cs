using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// Special Pythagorean triplet
    /// </summary>
    public class Euler9
    {
        /// <summary>
        /// a < b < c && a + b + c = 1000, a^2 + b^2 = c^2
        /// </summary>
        public static void FindTriplet()
        {
            int a = 0, b = 0, c = 0;

            // Initial value
            a = 1;

            do
            {
                b++;

                var aSqrd = Math.Pow(a, 2);
                var bSqrd = Math.Pow(b, 2);
                var aSqrdPlusbSqrd = aSqrd + bSqrd;

                var cDouble = Math.Sqrt(aSqrdPlusbSqrd);
                int.TryParse(cDouble.ToString(), out c);

                if (c != 0)
                {
                    if (a + b + c == 1000)
                    {
                        Console.WriteLine("Triplet found: a={0}, b={1}, c={2}", a, b, c);
                        Console.ReadLine();
                        break;
                    }
                }

                if (b != 1000) continue;
                a++;
                b = 0;

            } while (true);
        }
    }
}
