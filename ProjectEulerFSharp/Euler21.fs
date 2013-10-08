namespace Euler

(*

Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284.
The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

Evaluate the sum of all the amicable numbers under 10000.

*)

module Euler21 =

    // First get all proper divisors of n
    let d n = seq { for i = 1 to n / 2 do if n % i = 0 then yield i } |> Seq.sum

    // Find amicable numbers
    let AmicableNumberGen n =
        let da = d n
        let db = d da
        if da <> db && db = n then
            da
        else
            0

    // Sum of all sum of divisors under 10000.
    let iterator conditionNum =
        let sumOfSumOfDivisors = seq { for i = 1 to conditionNum do yield (AmicableNumberGen i) }
        let total = sumOfSumOfDivisors |> Seq.sum
        printfn "Euler 21 = %A"  total