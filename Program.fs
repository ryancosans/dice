open System

let rollDice count maxValue =
    let rnd = System.Random()
    List.init count (fun _ -> rnd.Next(1, maxValue + 1))

[<EntryPoint>]
let main _ =
    printfn "enter dice in format {numberOfDice}d{diceType} e.g: 1d10"
    let command = Console.ReadLine()

    let diceInfo = command.Split("d")

    let numberOfDice = diceInfo.[0] |> int
    let diceType = diceInfo.[1] |> int

    printfn "numberOfDice: %i diceType: d%i" numberOfDice diceType

    let diceRolls = rollDice numberOfDice diceType

    printfn "you rolled: %A" diceRolls

    printfn "for a total of: %i" <| List.sum diceRolls

    0 // return an integer exit code
