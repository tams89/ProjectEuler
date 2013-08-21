using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler2
    {
        public static void Fibonacci()
        {
            var fn = new List<int> { 0, 1 };
            var fneven = new List<int>();

            for (int i = 2; ; i++)
            {
                int fnext = fn[i - 1] + fn[i - 2];
                fn.Add(fnext);

                Console.WriteLine("Fib " + fn[i]);


                if (fn[i] % 2 == 0)
                    fneven.Add(fn[i]);
                Console.WriteLine(fneven.Sum());
                if (fn[i] >= 4000000)
                    Console.Read();
            }
        }
    }
}
