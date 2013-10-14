namespace Euler

open System
open System.Threading
open System.Threading.Tasks

(*
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
*)

module Euler26 =

//    let rec longDivision num div rem fraction:list<int> =
//        // Divide 1 by divisor if rem is less than 1 then
//        // multiply num by 10 and repeat -> get the remainder if this calc (int)
//        // and multiply by 10 and repeat again.
//        let divide = num % div

    let repeatFinder (decimal:int) =
//        let decString = (1M % System.Decimal(decimal)).ToString()
        let rem = ref 0
        let decString = System.Math.DivRem(1, decimal, rem).ToString()
        let firstDecVal = decString.IndexOf('.') + 1
        let startValue = decString.[firstDecVal] // first number after decimal point.
        let nextOccurenceOfStartValue = [ for i = firstDecVal to decString.Length - 1 do if decString.[i].Equals(startValue) then yield i ]
        if nextOccurenceOfStartValue.Length > 1 then
            let repeatUnit = nextOccurenceOfStartValue.[1] - nextOccurenceOfStartValue.[0]
            if repeatUnit > 1 then
                (repeatUnit, decimal)
            else
                (0,0)
        else
            (0,0)

    let answer =
        let ans = [ for i = 1 to 1000 - 1 do yield repeatFinder i ] |> List.max
        printfn "%A" ans
        ans