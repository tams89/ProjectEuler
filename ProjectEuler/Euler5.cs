using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// Smallest multiple
    /// </summary>
    public class Euler5
    {
        public static void SmallestMultiple()
        {
            int p = 0, i;

            do
            {
                p++;

                for (i = 1; i <= 20; i++)
                {
                    if (p % i != 0) break;
                }
            } while (i <= 20);

            Console.WriteLine(p);
            Console.Read();
        }
    }
}
