(*Назавание модуля*)
module Program3

(*Функция для уменьшения в 2 раза четных элементов, стоящих между нечетными*)
let modifyArray (arr: int[]) =
    for i in 1..(Array.length arr - 2) do
        if arr.[i] % 2 = 0 && arr.[i - 1] % 2 <> 0 && arr.[i + 1] % 2 <> 0 then
            arr.[i] <- arr.[i] / 2