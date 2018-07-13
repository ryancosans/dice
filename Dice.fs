module Dice

open System
let rollDice (diceCommand: string) =
    let rolls =
        match diceCommand.Split 'd' |> (fun diceInfo -> (diceInfo.[0], diceInfo.[1])) with
            | (numberOfDice, maxValue) ->
                List.init (numberOfDice |> int) (fun _ -> Random().Next(1, (maxValue |> int) + 1))
    let sum = List.sum rolls
    (rolls, sum)