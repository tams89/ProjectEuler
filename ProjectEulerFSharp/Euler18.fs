namespace Euler

open System.Collections
open System.Collections.Generic
open System.Linq

(*
  By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.

     3
    7 4
   2 4 6
  8 5 9 3

 That is, 3 + 7 + 4 + 9 = 23.

 Find the maximum total from top to bottom of the triangle below:
 NOTE: As there are only 16384 routes, it is possible to solve this problem by trying every route. However, Problem 67, is the same challenge with a triangle containing one-hundred rows; it cannot be solved by brute force, and requires a clever method! ;o)
*)

module Euler18 =

//    let triangle =
//        [| [| 75; |];
//           [| 95; 64; |];
//           [| 17; 47; 82; |];
//           [| 18; 35; 87; 10; |];
//           [| 20; 04; 82; 47; 65; |];
//           [| 19; 01; 23; 75; 03; 34; |];
//           [| 88; 02; 77; 73; 07; 63; 67; |];
//           [| 99; 65; 04; 28; 06; 16; 70; 92; |];
//           [| 41; 41; 26; 56; 83; 40; 80; 70; 33; |];
//           [| 41; 48; 72; 33; 47; 32; 37; 16; 94; 29; |];
//           [| 53; 71; 44; 65; 25; 43; 91; 52; 97; 51; 14; |];
//           [| 70; 11; 33; 28; 77; 73; 17; 78; 39; 68; 17; 57; |];
//           [| 91; 71; 52; 38; 17; 14; 91; 43; 58; 50; 27; 29; 48; |];
//           [| 63; 66; 04; 68; 89; 53; 67; 30; 73; 16; 69; 87; 40; 31; |];
//           [| 04; 62; 98; 27; 23; 09; 70; 98; 73; 93; 38; 53; 60; 04; 23; |] |]

    // Down & diagonally right so adjacent elements going down.
    let triangle =
         [|[| 3; |];
           [| 7; 4; |];
           [| 2; 4; 6; |];
           [| 8; 5; 9; 3; |]|];

    let pathFinder =
        
        // Start with bottom row, add it to the row above and select the top x values
        // where x is the number of values in the row above.
        let summedRow = new List<List<int>>()
        let numRowsInTriangle = triangle.GetUpperBound(0)
        
        for i = triangle.GetUpperBound(0) downto triangle.GetLowerBound(0) + 1 do
         let rowAbove = triangle.[i - 1]
         let baseArray = triangle.[i]
         let sumList = new List<int>()

         // Bottom row initially equals triangles base. 
         // Then becomes the most recently summed row in summedRows.
         let bottomRow = 
            match i with
               | i when i = triangle.GetUpperBound(0) -> triangle.[i].ToList()
               | _ -> summedRow.Last()
         
         for x = 0 to baseArray.GetUpperBound(0) do 
           
           // Add each value in row below to:
           // 1. the value directly above
           // 2. the value diagonally to the left and up.
           
           let mutable valueAbove = 0
           try 
            valueAbove <- triangle.[i - 1].[x]
           with 
             | :? System.Exception -> printfn "Error no value above"
           
           let mutable valueUpAndLeft = 0
           try
               valueUpAndLeft <- triangle.[i - 1].[x - 1]
           with 
               | :? System.Exception -> printfn "Error no value to above and to the left"

           // Add the found values.
           let sumWithAbove = bottomRow.[x] + valueAbove
           let sumWithAboveAndLeft = bottomRow.[x] + valueUpAndLeft

           // Add sums to list.
           sumList.Add(sumWithAboveAndLeft)
           sumList.Add(sumWithAbove)

         // Select max x element from sumList where x is the number of elements in the row above.
         let filterValue = sumList.OrderByDescending(fun i -> i).ToList().[rowAbove.Length]
         let filterForMaxX = sumList.Where(fun x -> x > filterValue).ToList()
         summedRow.Add(filterForMaxX)
        
        summedRow.Last().Max() // max value from last array