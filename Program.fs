module Program

open System
open Dice

let roll = fun _ ->
  let n = Environment.NewLine
  printfn "%senter dice in format {numberOfDice}d{diceType} e.g: 1d10" n
  match rollDice <| Console.ReadLine() with
      | (rolls, sum) -> printf "you rolled: %A total: %i" rolls sum

let rec repeat func =
  func()
  repeat func

[<EntryPoint>]
  let main _ =
    repeat <| roll
    0
