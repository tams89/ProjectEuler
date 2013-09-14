namespace Euler
    module Main =
        [<EntryPoint>]
        let main args =
            printfn "ans %A" (Euler17.sumAllCharsInNumberWordSequence 1 1000)
            0 // return an integer exit code