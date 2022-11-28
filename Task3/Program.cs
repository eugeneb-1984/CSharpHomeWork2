// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели от 1 до 7: ");
string input = Console.ReadLine();
bool isNumber = Int32.TryParse(input, out int dayNumber);
if (isNumber && dayNumber > 0 && dayNumber < 8) {
    if (dayNumber < 6) {
        Console.WriteLine("нет");
    }
    else {
        Console.WriteLine("да");
    }
}
else {
    Console.WriteLine("Вы ошиблись при вводе. Введите номер от 1 до 7");
}