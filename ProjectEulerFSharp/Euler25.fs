namespace Euler

open System
open System.Collections
open System.Collections.Generic

(*
    The Fibonacci sequence is defined by the recurrence relation:
    
    Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
    Hence the first 12 terms will be:
    
    F1 = 1
    F2 = 1
    F3 = 2
    F4 = 3
    F5 = 5
    F6 = 8
    F7 = 13
    F8 = 21
    F9 = 34
    F10 = 55
    F11 = 89
    F12 = 144
    The 12th term, F12, is the first term to contain three digits.
    
    What is the first term in the Fibonacci sequence to contain 1000 digits?
*)

module Euler25 = 
    let ThousandDigitFib = 
        let mutable fibNMinusOne = 0I
        let mutable fibNMinusTwo = 1I
        let mutable fnext = 0I
        let mutable counter = 1I
        while fnext.ToString().Length < 1000 do
            fnext <- fibNMinusOne + fibNMinusTwo
            fibNMinusOne <- fibNMinusTwo
            fibNMinusTwo <- fnext
            counter <- counter + 1I
            if fnext.ToString().Length >= 1000 then
                printfn "First 1000 digit Fibonacci number %A" fnext
                printfn "First term to contain a 1000 digit Fibonacci number %A" counter