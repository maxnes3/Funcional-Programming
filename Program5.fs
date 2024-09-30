module Program5

open System.IO
open System.Threading.Tasks
open System.Collections.Concurrent

let countVowels (text: string) =
    let vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ"
    text
    |> Seq.filter (fun c -> vowels.Contains(c))
    |> Seq.groupBy id
    |> Seq.map (fun (vowel, occurrences) -> vowel, Seq.length occurrences)
    |> Map.ofSeq

let processFile (filePath: string) =
    let text = File.ReadAllText(filePath)
    countVowels text

let processFilesParallel (filePaths: string[]) =
    let results = ConcurrentBag<Map<char, int>>()

    Parallel.ForEach(filePaths, fun filePath ->
        let result = processFile filePath
        results.Add(result)
    ) |> ignore

    results
    |> Seq.reduce (fun acc map ->
        map |> Map.fold (fun acc k v ->
            Map.add k (v + Map.find k acc) acc
        ) acc
    )