namespace Euler
(*
    Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
    21 22 23 24 25
    20  7  8  9 10
    19  6  1  2 11
    18  5  4  3 12
    17 16 15 14 13
    It can be verified that the sum of the numbers on the diagonals is 101.
    What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?

    Pattern: 
    0,0     center/start
    1,0     right
    1,-1    down
    0,-1    left
    -1,-1   left
    -1,0    up
    -1,1    up
    0,1     right 
    1,1     right

    Each consecutive layer contains 2^layerDepth elements.
*)
module Euler28 = 
    let right (x:int,y:int) = (x+1,y)    
    let down (x:int,y:int) = (x,y-1)
    let left (x:int,y:int) = (x-1,y)
    let up (x:int,y:int) = (x,y+1)

    let Grid = Array2D.zeroCreate<int> 1001 1001 // creates 1001x1001 grid with all values set to 0.
    Grid.[501,501] <- 1 // starting element

    for i = 0 to 1001 - 1 do Grid.[0,i] <- 1 + i // top row
    for i = 1001 - 2 downto 0 do Grid.[i,0] <- 1 + i // left column