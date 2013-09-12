namespace Euler

(*
    215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    What is the sum of the digits of the number 21000?
*)
module Euler16 =

    let largeNum num power =
        let sequence = seq { for i in 1 .. power do yield 2I }
        let mutable productOfSequence = 1I
        for x in sequence do
         productOfSequence <- productOfSequence * x
        productOfSequence

    let sumOfDigitsOfPoweredNum num power =
        let digitsToSum = (largeNum num power).ToString()
        let mutable totalProduct = 0I
        for x in digitsToSum do
            totalProduct <- totalProduct + bigint.Parse(x.ToString())
        totalProduct