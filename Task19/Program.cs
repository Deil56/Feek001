/* Задача 19

Напишите программу,
1. Которая принимает на вход пятизначное число и 
2. Проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212->нет
12821->да
23432->да */
/* string finAnswer = palindrome == true ? $"Число {number} -> является палиндромом!" : $"Число {number} -> не является палиндромом!";
Console.WriteLine(finAnswer); */

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32((Console.ReadLine()));

int interval = Interval(number);
int Interval(int num)
{
    while (((num < -99999) || ((num > -10000) && (num < 10000)) || (num > 99999)))
    {
        Console.WriteLine("Число не является пятизначным!");
        Console.WriteLine("Введите новое число ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}


bool palindrome = Palindrome(number);
if (palindrome)
{
    Console.WriteLine($"число {number} -> являеться палиндромом");
}
else
{
    Console.WriteLine($"Число {number} -> не является палиндромом");
}

bool Palindrome(int num)
{
    int firstN = num / 10000;
    int secondN = num / 1000 % 10;
    int fourthN = num % 100 / 10;
    int fifthN = num % 10;
    return firstN == fifthN && secondN == fourthN ? true : false;
}