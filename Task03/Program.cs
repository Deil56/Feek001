﻿/* Напишите программу.
1. Которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница */

Console.WriteLine("Введите номер дня недели");
int n = Convert.ToInt32(Console.ReadLine());

if(n < 1 | n > 7)
{
    Console.WriteLine("Неправильно ввели число");
}
else if (n == 1)
{
    Console.WriteLine("Понедельник");
}
else if (n == 2)
{
    Console.WriteLine("Вторник");
}
else if (n == 3)
{
    Console.WriteLine("Среда");
}
else if (n == 4)
{
    Console.WriteLine("Четверг");
}
else if (n == 5)
{
    Console.WriteLine("Пятница");
}
else if (n == 6)
{
    Console.WriteLine("Суббота");
}
else if (n == 7)
{
    Console.WriteLine("Воскресенье");
}