namespace Euler
    module Main =
        [<EntryPoint>]
        let main args =
            printfn "ans %A" (Euler21.iterator 10000)
            0