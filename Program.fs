(*Назавание модуля*)
module Program

(*Функция конвертирует число в строчку и проверяет наличие символа 9*)
let containsNine n =
    n.ToString().Contains('9')

(*Создание массива чисел от 1 до 100*)
let numbers = [1..100]

(*Функция проверяет значение по состветствию условия containsNine и находит их сумму*)
let sum = 
    numbers 
    |> List.filter containsNine
    |> List.sum