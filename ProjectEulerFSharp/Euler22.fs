namespace Euler

(*
    Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.
    Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

    For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
    So, COLIN would obtain a score of 938 × 53 = 49714.

    What is the total of all the name scores in the file? 871198282
*)

module Euler22 =

    let letterToValue (letter:char) = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(letter) + 1
    let nameToValue (name:string) = seq { for c in name do yield (letterToValue c) } |> Seq.sum
    let answer =
        // Read text file into string array -> string list -> alphabetize list.
        let nameList = System.IO.File.ReadAllText(@"C:\Users\Tam\Documents\Visual Studio 2013\Projects\ProjectEuler\ProjectEulerFSharp\names.txt").Split(',') |> Array.toList |> List.sort
        // Translate names into numerical scores.
        let nameScoreList = [ for name in nameList do yield nameToValue name ]
        // Multiple each name score by its sorted position.
        let multiplyNameScoreByPosition = seq { for i = 0 to nameScoreList.Length - 1 do yield (nameScoreList.[i] * (i + 1)) } |> Seq.sum
        printfn "%A" multiplyNameScoreByPosition
        multiplyNameScoreByPosition