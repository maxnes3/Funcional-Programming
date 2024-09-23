(*Назавание модуля*)
module Program2

(*Импорт модулей*)
open System
open System.IO

// Функция для подсчета гласных в тексте
let countVowels (text: string) =
    let vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ"
    text
    |> Seq.filter (fun c -> vowels.Contains(c))
    |> Seq.groupBy id
    |> Seq.map (fun (vowel, occurrences) -> vowel, Seq.length occurrences)
    |> Map.ofSeq

// Чтение текста из файла
let readTextFromFile (filePath: string) =
    if File.Exists(filePath) then
        File.ReadAllText(filePath)
    else
        failwithf "File not found: %s" filePath
