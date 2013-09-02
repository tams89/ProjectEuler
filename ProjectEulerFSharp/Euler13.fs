namespace Euler

open System.IO
open System.Linq
open System

// Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
module Euler13 = 
    
    let HundredFiftyDigitNums = 
        let mutable sumOfBigInts = 0I;
        let file = File.OpenText(@"C:\Users\Tamesh\Documents\Visual Studio 2012\Projects\ProjectEuler\ProjectEulerFSharp\Euler13.txt")
        let str = file.ReadToEnd()
        let array = str.Split [| '\n' |]
        for strNum in array do
            let num = bigint.Parse(strNum)
            sumOfBigInts <- sumOfBigInts + num
        sumOfBigInts
 
    let Sum50DigitNums = 
        let x = 1
        printfn "digits %A" HundredFiftyDigitNums
