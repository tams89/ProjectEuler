using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler1
    {
        public static void MultipleSum()
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }

            }

            Console.WriteLine(sum.ToString());
            Console.WriteLine("Press ANY Key to continue");
            Console.ReadKey();
        }
    }
}
