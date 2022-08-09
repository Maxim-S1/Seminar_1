// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 7 & day >= 1)
{
    if(day == 1)
    {
     Console.Write("Понедельник");   
    }
    if(day == 2)
    {
     Console.Write("Вторник");   
    }
    if(day == 3)
    {
     Console.Write("Среда");   
    }
    if(day == 4)
    {
     Console.Write("Четверг");   
    }
    if(day == 5)
    {
     Console.Write("Пятница");   
    }
    if(day == 6)
    {
     Console.Write("Суббота");   
    }
    if(day == 7)
    {
     Console.Write("Восскресенье");   
    }
}
else
{
  Console.Write("Нет такого дня недели((");  
}
