/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
 */

int number = new Random().Next(100, 1000);
int finaleNumber = DeleteSecond(number);
Console.WriteLine($"трехзначное число {number} -> с удаленной второй цифрой {finaleNumber}");

 int DeleteSecond(int num)
{
    int firstNumber = num /100;
    int lastNumber = num %10;
    int finaleNumber = firstNumber * 10 + lastNumber;
    return finaleNumber;
}