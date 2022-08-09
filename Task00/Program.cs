// Задача 0

Console.Write("Введите число: "); // 1. Приглашение к вводу
// int number = Convert.ToInt32(ConConsole.ReadLine()); // 2. Считывание данных с консоли в тип Int
string? str = Console.ReadLine(); // 2.1 Считываем данные с консоли
int number = Convert.ToInt32(str); // 2.2 Конвертируем, полученные данные в число
Console.Write(number * number); // 3. Вывод на экран число возведенное во 2 степень
