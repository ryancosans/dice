module Tests

open Xunit
open Dice

[<Fact>]
let ``roll three d10 dice`` () =
    match rollDice "3d10" with
        | (rolls, sum) -> Assert.True(rolls.Length = 3 && (sum >= 3 && sum <= 30))

[<Fact>]
let ``roll ten d5 dice`` () =
    match rollDice "10d5" with
        | (rolls, sum) -> Assert.True(rolls.Length = 10 && (sum >= 10 && sum <= 50))

[<Fact>]
let ``roll one hundred d4 dice`` () =
    match rollDice "100d4" with
        | (rolls, sum) -> Assert.True(rolls.Length = 100 && (sum >= 100 && sum <= 400))