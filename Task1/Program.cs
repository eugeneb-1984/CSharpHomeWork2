// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное целое число: ");
string input = Console.ReadLine();
bool isNumber = Int32.TryParse (input, out int number);
if (isNumber && number > 99 && number < 1000) {
    int secondDigit = number / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {number}: {secondDigit}");
}
else {
    Console.WriteLine("Вы ошиблись при вводе. Введите трёхзначное целое число.");
}
