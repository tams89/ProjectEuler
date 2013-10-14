namespace Euler

(*
    A permutation is an ordered arrangement of objects.

    For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4.
    If all of the permutations are listed numerically or alphabetically, we call it lexicographic order.
    The lexicographic permutations of 0, 1 and 2 are:    012   021   102   120   201   210

    What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
*)

open System.Collections.Generic

module Euler24 =

    let answer =

        let rec factorial x =
            if x <= 0 then
                1
            else
                x * factorial (x - 1)

        let list = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]

        let rec lexPermute (digits:List<int>) lexPosition =
            // If one digit left to permute then answer has been found as 1! = 1.
            if digits.Count = 1 then
                [digits.[0]]
            else
                let availablePermutations = (factorial digits.Count) / digits.Count
                let digitToSplitIdx = lexPosition / availablePermutations
                let digitSplit = digits.[digitToSplitIdx]
                digits.RemoveAt(digitToSplitIdx)
                digitSplit :: (lexPermute digits (lexPosition - availablePermutations * digitToSplitIdx))

        let result =
            lexPermute (new List<int>(list)) (int(1e6) - 1)

        printfn "%A" result

//        let permutation  n array =
//            let length = Array.length array
//            if n > 0 && n < length then Array.permute (fun index -> (index + n) % length) array
//            else array
//            |> printfn "%A"
//        for n in 0..9 do
//            permutation n array