namespace Euler

(*

Euler discovered the remarkable quadratic formula:
n² + n + 41

It turns out that the formula will produce 40 primes for the consecutive values n = 0 to 39. 
However, when n = 40, 402 + 40 + 41 = 40(40 + 1) + 41 is divisible by 41, and certainly when n = 41, 41² + 41 + 41 
is clearly divisible by 41.

The incredible formula  n² − 79n + 1601 was discovered, which produces 80 primes for the consecutive values n = 0 to 79. 
The product of the coefficients, −79 and 1601, is −126479.

Considering quadratics of the form:
n² + an + b, where |a| < 1000 and |b| < 1000
where |n| is the modulus/absolute value of n
e.g. |11| = 11 and |−4| = 4

Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n = 0.

*)

module Euler27 =
 
 let eulerFormula n1 n2 = (n1 ** 2.0f) - (79.0f * n2) + 1601.0f

 // Example - for n = 79 generates 80 primes. Each prime occurs twice in parabolic fashion.
 let incredibleFormula = 
  let primes = seq { for n in 0.0f..79.0f do yield (n ** 2.0f) - (79.0f * n) + 1601.0f }
  sprintf "Number of primes: %A" (primes |> Seq.length)
  sprintf "Number of unique primes: %A" (primes |> Seq.distinct |> Seq.length)

 let isPrime n =
        match n with
        | a when a < 2 -> false // if n is less than two then return false.
        | 2 -> true // if n = 2 then return true
        | _ -> // anything else. 
            { 3..2..(int((float n)**0.5) + 1) } // all odd numbers from 3 to sqrt of n + 1
            |> Seq.exists ( fun x -> if n % x = 0 then true else false) // if the number can be divided by any odd number in sequence then not a prime.
            |> not

 let eulerQuadratic a b = Seq.initInfinite (fun n -> (n*n) + a*n + b)

 [| for b in (Seq.filter isPrime { 1..2..999 }) do // be must be prime and range from 1 to 999 as its ^2 so always positive.
     // a must be prime and range from -999 to 999 as < 1000
     for a in { -999..2..999 } do if (isPrime (1+a+b)) then yield (lazy(a*b), eulerQuadratic a b) |] // returns a tuple (the product of a and b coeffiecients, sequence for that particular values of a and b) 
      |> Array.Parallel.map (fun (ab, seq) -> ab, (Seq.findIndex (isPrime >> not) seq)) // return sequences where its index is not a prime.
      |> Array.maxBy snd // maximum length sequence
      |> fun (ab,length) -> ( printfn "longest prime seq: %A and coef. product: %A" length ab.Value )