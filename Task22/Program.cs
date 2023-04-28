/* Задача 22: Напишите программу, которая
1. принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N. */

System.Console.Write("Введите число (N): ");
int number = Convert.ToInt32(Console.ReadLine());

/* int square = Math.Sqrt(number, 2); */

/* for (int i=0; i <= number; i++)
{
Console.WriteLine(Math.Pow(i,2));
} */
Table(number);

void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3} {count * count, 5}");
        count ++;
    }

}
 