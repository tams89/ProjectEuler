namespace Euler

open System
open System.Linq
open System.Collections
open System.Collections.Generic

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

    /// Matches a single digit number to its word equivalent.
    let matchUnit num =
        match num with
            | x when x = 0  -> "naught"
            | x when x = 1  -> "one"
            | x when x = 2  -> "two"
            | x when x = 3  -> "three"
            | x when x = 4  -> "four"
            | x when x = 5  -> "five"
            | x when x = 6  -> "six"
            | x when x = 7  -> "seven"
            | x when x = 8  -> "eight"
            | x when x = 9  -> "nine"
            | _ -> ""

    /// Matches a number in the tens to its word equivalent.
    let matchTen num =
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
            | _ -> ""

    /// The largest unit the number consists of.
    let matchMagnitide num =
        match num with
            | x when x.ToString().Length = 2 -> "ten"
            | x when x.ToString().Length = 3 -> "hundred"
            | x when x.ToString().Length = 4 -> "thousand"
            | _ -> ""

    // Active pattern to return null if parse fails.
    // Some(int) returned if parse successful.
    let res chars =
        match Int32.TryParse chars with
            | (true, result) -> Some result
            | (false, _) -> None

    /// Gives a number by position and length start with the input number.
    let numAtPosition (num:int) (position:int) (length:int) =
        let mutable chars = ""
        let parse = ref 0
        // check args are valid, if valid proceed with substring.
        if (num.ToString().Length >= position - length) && (position - 1 >= 0) then
            chars <- num.ToString().Substring(position - 1, length)
        (res chars) // return active pattern based try parse for the int from string.

    let wordForTenUnit num =
        let mutable ans = ""
        let tens = numAtPosition num 1 2
        let exactMatch = matchTen tens.Value
        let magnitude = matchMagnitide num
        if tens.IsSome && magnitude.Contains("ten") && exactMatch <> "" then // direct match
            ans <- matchTen tens.Value
        elif tens.IsSome && magnitude.Contains("ten") && exactMatch = "" then // construct word
            let first = matchTen ((numAtPosition num 1 1).Value * 10)
            let last = matchUnit (numAtPosition num 2 1).Value
            ans <- first + " " + last
        ans

    let matchNumberToWord num =
        let mutable ans = ""
        if num.ToString().Length = 1 then
            ans <- matchUnit num
        else
            let strList = new List<string>()
            let firstWord = matchUnit (numAtPosition num 1 1).Value // should be a single digit int.
            let magnitude = matchMagnitide num
            if magnitude.Contains("ten") then
                ans <- wordForTenUnit num
            elif magnitude.Contains("hundred") then
                if num.ToString().Contains("00") then
                    ans <-  firstWord + " hundred"
                elif (numAtPosition num 2 1).Value = 0 then
                    ans <- firstWord + " " + magnitude + " and " + matchUnit (numAtPosition num 3 1).Value
                else
                    ans <- firstWord + " " + magnitude + " and " + wordForTenUnit (numAtPosition num 2 2).Value
            elif magnitude.Contains("thousand") then
                if num.ToString().Contains("000") then
                    ans <- firstWord + " thousand"
                elif (numAtPosition num 3 1).Value = 0 then
                    ans <- firstWord + " " + magnitude + " and " + matchUnit (numAtPosition num 4 1).Value
                else
                    let hundred = matchUnit (numAtPosition num 2 1).Value
                    ans <- firstWord + " " + magnitude + " and " + hundred + " hundred and " + wordForTenUnit (numAtPosition num 3 2).Value
        ans // return

    /// Sum of all word numbers from 1..1000
    let sumAllCharsInNumberWordSequence start stop =
        let mutable sumChars = 0
        for i = start to stop do
            let currentWord = (matchNumberToWord i).Replace(" ", "")
            sumChars <- sumChars + currentWord.Length
        sumChars