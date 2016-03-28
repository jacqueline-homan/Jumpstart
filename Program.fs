open System
open System.IO

let x = 42
let n = [1..9]

let length = [0..99]
let width = [0..99]

let area l w =
    l * w

let printNumbers min max =
    let square n =
        n * n
    for i in min..max do
        printfn "%i %i" x (square x)
(printNumbers 10 20)
printfn "OK. Well that was interesting... "
printfn ""

let randomPosition() =
    let r = new System.Random()
    r.NextDouble, r.NextDouble

let files = Directory.EnumerateFiles(@"/home/jacqueline", "*.odt" )
printfn "%A" files

let fruits =
    [|
        "apple"
        "cherry"
        "peach"
        "blueberry"
        "rhubarb"
        "cantaloupe"
        "pomegranet"
    |]
printfn "%A" fruits

let numbers = [|0..99|]
let squares = [| for i in 0..99 do yield i * i|]
                   
let randomFruits count =
    let r = new System.Random()
    let fruits = [|"apple";"cherry";"peach";"blueberry";"rhubarb";"cantaloupe";"pomegranet"|]     

    [|
        for i in count do
            let index = r.Next(3)
            yield fruits.[index]
    |]
printfn "%A" fruits.[3]

let randomFruits2 count =
    let r = System.Random()
    let fruits = [|"apple";"cherry";"peach";"blueberry";"rhubarb";"cantaloupe";"pomegranet"|]
    Array.init count (fun _ ->
        let index = r.Next(3)
        fruits.[index]
    )

let likeSomeFruits fruits =
    for fruit in fruits do
        printfn "I like %s" fruits
  
// In F# interactive, declare a function: let rf = randomFruits2 10;;
//then declare another function: let first = rf.[0];;
//Now call another function in F# interactive: likeSomeFruit rf;;

let moreSquares =
    [|
        for i in 0..99 do
            yield i * i
    |]

let isEven n =
    n % 2 = 0

let evenSquares = Array.filter(fun x -> isEven x) moreSquares
printfn "%A" evenSquares


let likeSomeFruit2 fruits =
    Array.iter (fun fruit -> printfn "I like %s" fruit) fruits
likeSomeFruit2 fruits

let printLongAssWords (words : string[]) =
    let longAssWords : string [] = Array.filter (fun w -> w.Length > 8) words
    let sortedLongAssWords = Array.sort longAssWords
    Array.iter (fun w -> printfn "%s" w) sortedLongAssWords

let printMoarLongAssWords (words : string []) =
    words
    |> Array.filter (fun w -> w.Length > 8)
    |> Array.sort
    |> Array.iter (fun w -> printfn "%s" w) 

let printSquares min max =
    let square n =
        n*n
    for i in min..max do
        printfn "%i" (square i)

let printSquares2 min max =
    let square n =
        n*n
    [|min..max|]
    |> Array.map (fun i -> square i)
    |> Array.iter (fun s -> printfn "%i" s)
printSquares2 2 5
 





[<EntryPoint>]
let main argv = 
    //printfn "%A" argv
    0 // return an integer exit code

