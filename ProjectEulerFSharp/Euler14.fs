namespace Euler

open System
open System.Collections
open System.Collections.Generic

(*The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.*)
module Euler14 = 
 
 // Conjecture formula
 let conjecture n:int64 = 
  let mutable returnVal = 0L
  if n % 2L = 0L then returnVal <- (n/2L) // if n is even
  else returnVal <- (3L * n) + 1L // if n is odd
  returnVal

 let sequence startVal = 
  
  // Set variables
  let mutable numberWithLongestChainSoFar = 0
  let mutable longestChainSoFar = 0
  let mutable chainLength = 0
  
  // Iterate start to one million - 1
  for i = startVal to (int)999999 do
   
   // Clear current number value.
   chainLength <- 0
   chainLength <- chainLength + 1

   // Generate series
   let mutable a = int64(i)
   while a <> 1L do
    
    // If a is not one then get the next element in conjecture.
    let x = conjecture a

    // Looking for postive integers so rule out negative ones.
    if x < 0L then a <- 1L // Set to one to break out of while loop.
    
    // Add one to current seq length counter.
    else 
     chainLength <- chainLength + 1
     a <- x

    // Maintain history of largest collection so far and its starting number.
    if longestChainSoFar < chainLength then
        longestChainSoFar <- chainLength
        numberWithLongestChainSoFar <- i

  numberWithLongestChainSoFar // return
     
 let IterateThroughStartVals = 
    sequence 13 // Starts iterations at 13.