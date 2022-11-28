// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
string input = Console.ReadLine();
bool isNumber = Int32.TryParse (input, out int result);
if (isNumber) {
    if (input.Length >=3) {
    Console.WriteLine(input[2]);
    }
    else {
        Console.WriteLine("Третьей цифры нет");
    }
}
else {
    Console.WriteLine("Вы ошиблись при вводе. Введите целое число");
}
