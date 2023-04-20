/* Напишите программу, которая на вход принимает 
1.два числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */

Console.WriteLine("введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int square1 = Square(num2);
if (square1 == num1)
{
Console.Write("Да");
}
else 
{
  Console.Write("Нет");  
}

int Square (int a)
{
    return a * a;
}