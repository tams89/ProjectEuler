namespace Euler

open System

(*
    If the numbers 1 to 5 are written out in words: one, two, three, four, five,
    then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

    If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words,
    how many letters would be used?

    NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two)
    contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
    The use of "and" when writing out numbers is in compliance with British usage.
*)

module Euler17 =

    let numToUnitWord num =
        match num with
            | x when x = 0  -> "zero"
            | x when x = 1  -> "one"
            | x when x = 2  -> "two"
            | x when x = 3  -> "three"
            | x when x = 4  -> "four"
            | x when x = 5  -> "five"
            | x when x = 6  -> "six"
            | x when x = 7  -> "seven"
            | x when x = 8  -> "eight"
            | x when x = 9  -> "nine"
            | _ -> (new Exception("Unit word error")).Message

    let numToTenWord num =
        match num with
            | x when x = 10 -> "ten"
            | x when x = 11 -> "eleven"
            | x when x = 12 -> "twelve"
            | x when x = 13 -> "thirteen"
            | x when x = 14 -> "fourteen"
            | x when x = 15 -> "fifteen"
            | x when x = 16 -> "sixteen"
            | x when x = 17 -> "seventeen"
            | x when x = 18 -> "eighteen"
            | x when x = 19 -> "nineteen"
            | x when x = 20 -> "twenty"
            | x when x = 30 -> "thirty"
            | x when x = 40 -> "fourty"
            | x when x = 50 -> "fifty"
            | x when x = 60 -> "sixty"
            | x when x = 70 -> "seventy"
            | x when x = 80 -> "eighty"
            | x when x = 90 -> "ninety"
            | _ -> (new Exception("Ten Unit word error")).Message

    let numToLargestUnit num =
        match num with
            | x when x.ToString().Length = 2 -> "ten"
            | x when x.ToString().Length = 3 -> "hundred"
            | x when x.ToString().Length = 4 -> "thousand"
            | _ -> (new Exception("Largest Unit word error")).Message

    let numAtPosition (num:int) (position:int) (length:int) =
        let chars = num.ToString().Substring(position-1, length)
        Int32.Parse(chars)

    let test =
        printfn "%A" (numToUnitWord 0)
        printfn "%A" (numToTenWord 10)
        printfn "%A" (numToUnitWord 1)

    let hundredNumToWord (num:int) =
        let startUnit = numToUnitWord (numAtPosition num 1 1) // words "one" to "ten".
        let largestUnit = numToLargestUnit num // units -> "ten"/ "hundred"/ "thousand"
        let tenUnit = numToTenWord (numAtPosition num 2 2)
        printfn "%A" startUnit
        printfn "%A" largestUnit
        printfn "%A" tenUnit
        startUnit + " " + largestUnit + " and " + tenUnit

    let thousandNumToWord (num:int) =
        let largestUnit = numToLargestUnit num
        let restOfThousandNum = hundredNumToWord (Int32.Parse(num.ToString().Substring(1,3)))
        largestUnit + " " + restOfThousandNum

    let complexNumberToWord num =
        let mutable ans = ""
        if num.ToString().Length = 4 then
            ans <- (thousandNumToWord num)
        elif num.ToString().Length = 3 then
            ans <- (hundredNumToWord num)
        elif num.ToString().Length = 2 then
            ans <- (numToTenWord num)
        elif num.ToString().Length = 1 then
            ans <- (numToUnitWord num)
        else
            printfn "No match"
        ans