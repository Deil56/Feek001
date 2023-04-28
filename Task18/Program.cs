/* Задача 18: Напишите программу, которая 
1. по заданному номеру четверти, показывает диапазон
2. возможных координат точек в этой четверти (x и y).
 */

Console.WriteLine("Введите заданный номер четверти");
int Coordinate = Convert.ToInt32(Console.ReadLine());

string range = Range(Coordinate);
string result = range != "0"
                ? $"Заданный номер четверти показывает диапазон -> {range}"
                : "Введен некорректный ввод";
Console.WriteLine(result);

string Range( int numb)
{
    if (numb == 1) return "x > 0, y > 0";
    if (numb == 2) return "x < 0, y > 0";
    if (numb == 3) return "x < 0, y < 0";
    if (numb == 4) return "x > 0, y < 0";
    return "0";
}