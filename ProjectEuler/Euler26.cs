using System;

namespace ProjectEuler
{
    /*
        A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
        1/2	= 	0.5
        1/3	= 	0.(3)
        1/4	= 	0.25
        1/5	= 	0.2
        1/6	= 	0.1(6)
        1/7	= 	0.(142857)
        1/8	= 	0.125
        1/9	= 	0.(1)
        1/10	= 	0.1
        Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.
        Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
     */
    public class Euler26
    {
        public double Answer()
        {
            var sequenceLength = 0;
            var num = 0;

            // find the remainder for each denominator.
            for (int i = 1000; i > 1; i--)
            {
                if (sequenceLength >= i) break; // Prevent index out of range.
                var remainder = new int[i];     // Int array that stores the values of the remainder.
                var value = 1;
                var position = 0;

                while (remainder[value] == 0 && value != 0)
                {
                    remainder[value] = position;
                    value *= 10;
                    value %= i;
                    position++;
                }

                if (position - remainder[value] <= sequenceLength) continue;

                num = i; // number to evaluate.
                sequenceLength = position - remainder[value]; // the sequence length is 
            }

            Console.WriteLine("Divisor: {0}, Repeating unit length: {1}", num, sequenceLength);
            return sequenceLength;
        }
    }
}
