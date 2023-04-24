/* Напишите программу, которая выводит
1. cлучайное число 
2.из отрезка [10, 99] и
3.показывает наибольшую цифру числа. */
/* 78 -> 8
12-> 2
85 -> 8 */

int number = new Random().Next(10, 100); // (10, 99 + 1)
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}