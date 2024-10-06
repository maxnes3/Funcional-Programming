module Program6

(*Начальная аксиома*)
let axiom = "-F-F-F-F-"

(*Правило замены*)
let rule (c: char) =
    match c with
    | 'F' -> "F+F--F+F"
    | _ -> string c

(*Функция для выполнения одной итерации*)
let iterate (input: string) =
    input |> Seq.map rule |> String.concat ""

(*Функция для выполнения n итераций*)
let rec iterateN (input: string) (n: int) =
    if n <= 0 then
        input
    else
        iterateN (iterate input) (n - 1)

(*Функция для вывода результата*)
let printIterations (start: string) (iterations: int) =
    let result = iterateN start iterations
    printfn "Result after %d iterations:\n%s" iterations result