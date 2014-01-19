namespace Euler

(*
    The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.
    
    Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
    
    (Please note that the palindromic number, in either base, may not include leading zeros.)
*)

open System.Linq
open System

module Euler36 = 
    
    // Checks whether a nunber is a palindrome by comparing it to the reverse of itself.
    let palindromeIdentify testNum = 
        if testNum.ToString().Reverse().ToArray() <> testNum.ToString().ToArray() then false
        else true

    let convertToBase2 num = Convert.ToString(int(num), 2)

    let example = 
        let num = 585.0 // this is palindromic.
        let check = palindromeIdentify num // true
        let base2example = convertToBase2 59 // 111011
        let check2 = palindromeIdentify base2example // false
        let finalCheck = check = check2 // false
        printfn "isPalindrome: %A, Decimal: %A, Binary: %A" finalCheck num base2example

    let answer = 
        seq { for x in 0..(1000000-1) do 
                if palindromeIdentify x && palindromeIdentify (convertToBase2 x) 
                    then yield x }
        |> Seq.sum
