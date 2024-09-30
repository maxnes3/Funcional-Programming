(*Назавание модуля*)
module main

(*Импорт модулей*)
open Program
open Program2
open Program3
open Program4
open Program5
open System.IO

(*Начальная точка входа программы*)
[<EntryPoint>]
let main argv = 
    (* Лаборатоная работа #1 *)
    (*printfn "Сумма чисел от 1 до 100, содержащих цифру 9: %d" sum
    0*)

    (* Лабораторная работа #2 *)
    (*if argv.Length <> 1 then
        printfn "Usage: <program> <file-path>"
        1
    else
        let filePath = argv.[0]
        let text = readTextFromFile filePath
        let vowelCounts = countVowels text

        printfn "Vowel counts:"
        vowelCounts |> Map.iter (fun vowel count -> printfn "%c: %d" vowel count)

        0*)

    (* Лабораторная работа #3 *)
    (*let arr = [|1; 4; 16; 3; 6; 5; 8; 7; 10; 9|]
    
    printfn "Исходный массив: %A" arr
    
    modifyArray arr  // Модификация массива на месте
    
    printfn "Измененный массив: %A" arr
    
    0*)

    (*Лабораторная работа #4*)
    (*let emp1 = Employee("John Doe", 1) :> IEmployee
    let emp2 = Employee("Jane Smith", 2) :> IEmployee
    let mgr1 = Manager("Alice Johnson", 3, "Sales") :> IEmployee
    
    let hr = HRDepartment()
    hr.AddEmployee(emp1)
    hr.AddEmployee(emp2)
    hr.AddEmployee(mgr1)

    printfn "All Employees in HR Department:"
    hr.GetAllEmployees() |> List.iter (printfn "%s")

    0*)

    (*Лабораторная работа #5*)
    let files = [| "file1.txt"; "file2.txt"; "file3.txt" |]

    let totalVowelCounts = processFilesParallel files

    let outputFilePath = "output.txt"
    use writer = new StreamWriter(outputFilePath)
    totalVowelCounts |> Map.iter (fun vowel count ->
        writer.WriteLine(sprintf "%c: %d" vowel count)
    )

    printfn "Results written to %s" outputFilePath

    0 