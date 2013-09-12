namespace Euler

(*

Starting in the top left corner of a 2×2 grid,
and only being able to move to the right and down,
there are exactly 6 routes to the bottom right corner.

e.g. 2x2 - gives 3 unique sequences:
(right, down)
(down, right)
(down, down)

[ 1 , 2 ]
[ 3 , 4 ]

Then has to be x2? becuase paths move across grid edges not through elements.

How many such routes are there through a 20×20 grid?

*)

module Euler15 =

// Pure math approach.
    let factorial num =
        let mutable factorialResult = 1I
        for i = 1 to num do
            factorialResult <- factorialResult * bigint(i)
        factorialResult

    let binomialCoefficients n k =
            factorial(n) / (factorial(n-k)*factorial(k))

    let numPaths =
        printfn "Factorial n %A" (factorial 40) // 40 becuase thats the number of steps to get from top left to bottom right.
        printfn "Factorial k %A" (factorial 20) // 20 elements i.e. 20 left or rights must be present.
        binomialCoefficients 40 20

// Dynamic Programming Approach - multiple smaller function