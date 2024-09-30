(*Назавание модуля*)
module Program3

(*Функция для уменьшения в 2 раза четных элементов, стоящих между нечетными*)
let modifyArray (arr: int[]) =
    let mutable result = Array.copy arr
    for i in 1..(Array.length arr - 2) do
        if arr.[i] % 2 = 0 && arr.[i - 1] % 2 <> 0 && arr.[i + 1] % 2 <> 0 then
            result.[i] <- arr.[i] / 2
    result