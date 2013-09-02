namespace Euler

open System.Collections.Generic
open System.Collections
open System
open System.Linq

// What is the value of the first triangle number to have over five hundred divisors?
module Euler12 = 
    
    // Works but is very slow ~20mins on i5 @ 4.2Ghz
    let numDivisors = 
        
        // triangle number seed 
        let mutable triangleNumberSeed = 1
        
        // A triangle number.
        let mutable triangleNumber = 1
        
        // Number of divisors.
        let mutable numDivisors = 0
        
        // Loop int +1 and check number of divisors until condition.
        while numDivisors <= 500 do
        
            // Reset numDivisors & Triangle num
            triangleNumber <- 0
            numDivisors <- 0
        
            // Generate triangle num
            for i = 1 to triangleNumberSeed do
                triangleNumber <- triangleNumber + i

            // Count divisors of triangle number.
            for i = 1 to triangleNumber do
                if triangleNumber % i = 0 then
                    numDivisors <- numDivisors + 1

            // Increment triangle num.
            triangleNumberSeed <- triangleNumberSeed + 1
        
        // Return triangle num with over 500 divisors.
        printfn "triangle number is %d, num. divisors is %d" triangleNumber numDivisors
        numDivisors