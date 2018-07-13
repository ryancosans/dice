module Program

open System
open Dice

[<EntryPoint>]
  let main _ =
    printfn "enter dice in format {numberOfDice}d{diceType} e.g: 1d10"

    match rollDice <| Console.ReadLine() with
        | (rolls, sum) -> printfn "you rolled: %A total: %i" rolls sum

    0