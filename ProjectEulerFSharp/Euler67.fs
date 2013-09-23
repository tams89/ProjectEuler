namespace Euler

open System
open System.Linq
open System.IO
open System.Text

module Euler67 = 
    // Form jagged array with data in text file.
    let triangle = 
        let strArray = File.ReadAllLines(@"\Users\Tam\Documents\Visual Studio 2013\Projects\ProjectEuler\ProjectEulerFSharp\triangle.txt")
        let intArray : int[][] = [| for string in strArray do yield! [| string.Split([| ' ' |]).Select(fun x -> int(x)).ToArray() |] |] 
        let ans = Euler18.AddBottomRowToRowAbove intArray
        printfn "Euler 67 = %A" (ans.Last())