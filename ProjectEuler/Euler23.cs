using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProjectEuler
{
    using System.Collections;

    public class Euler23
    {
        public int Result()
        {
            var abundant = AbdundantNumbers();
            return NonAbundantNums(abundant);
        }

        private static int sumOfProperDivisors(int n)
        {
            var properDivs = new BitArray(28123 + 1, false);
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0) properDivs[i] = true;

            int sum = 0;
            for (int i = 0; i <= properDivs.Count - 1; i++)
                if (properDivs[i]) sum += i;

            return sum;
        }

        private IReadOnlyList<int> AbdundantNumbers()
        {
            var abundantNums = new Collection<int>();
            for (var i = 1; i <= 28124; i++)
                if (sumOfProperDivisors(i) > i) abundantNums.Add(i);
            return abundantNums;
        }

        private int NonAbundantNums(IReadOnlyList<int> abundantNums)
        {
            var noAbundantSum = new bool[28123 + 1];
            for (int i = 0; i < abundantNums.Count; ++i)
                for (int j = i; j < abundantNums.Count; ++j)
                {
                    var sum = abundantNums[i] + abundantNums[j];
                    if (sum < 28124) noAbundantSum[sum] = true;
                    else break;
                }

            var total = 0;
            for (int i = 0; i < 28124; ++i) if (!noAbundantSum[i]) total += i;
            return total;
        }
    }
}
