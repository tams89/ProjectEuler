using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// Largest palindrome product
    /// </summary>
    public static class Euler4
    {
        public static void LargestPalindromeProduct()
        {
            //iterate through all ...x... and check for obj1 = obj2 where obj2 = obj1.to array, and then compare each element in the array
            (from x in 100.MultiplicationValue(999)
             from y in 100.MultiplicationValue(999)
             let product = x * y
             where product.IsPalindrome()
             orderby product descending
             select product).First().DisplayAndPause();
        }

        private static void DisplayAndPause(this int number)
        {
            Console.WriteLine(number);
            Console.Read();
        }

        private static IEnumerable<int> MultiplicationValue(this int first, int last)
        {
            for (var i = first; i <= last; i++)
            {
                yield return i;
            }
        }

        private static bool IsPalindrome(this int number)
        {
            var digits = number.ToString().ToCharArray();
            return digits.SequenceEqual(digits.Reverse());
        }
    }
}
