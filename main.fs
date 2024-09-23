(*Назавание модуля*)
module main

(*Импорт модулей*)
open Program
open Program2

(*Начальная точка входа программы*)
[<EntryPoint>]
let main argv = 
    (* Лаборатоная работа #1 *)
    (*printfn "Сумма чисел от 1 до 100, содержащих цифру 9: %d" sum
    0*)

    (* Лабораторная работа #2 *)
    if argv.Length <> 1 then
        printfn "Usage: <program> <file-path>"
        1
    else
        let filePath = argv.[0]
        let text = readTextFromFile filePath
        let vowelCounts = countVowels text

        printfn "Vowel counts:"
        vowelCounts |> Map.iter (fun vowel count -> printfn "%c: %d" vowel count)

        0

    (* Лабораторная работа #3 *)