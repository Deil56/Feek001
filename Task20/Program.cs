
/* A1A2 = 2((x2-x1)2 + (y2-y1)2) */
/* double d = Math.Sqrt(5);
double num = 5.099786332;
double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
Console.WriteLine (numRound); */

/* Задача 20: Напишите программу, которая
1.принимает на вход координаты двух точек и
2.находит расстояние между ними в 2D
пространстве.
A (3,6); B(2, 1)-> 5,09
A(7, -5); B(1, -1)-> 7,21
 */

System.Console.Write("Введите координату X1: ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y1: ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату X2: ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y1: ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, xB, yB);
System.Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    double square = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return square;
}

/* Console.WriteLine("Введите координаты точки A");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, yA, xB, yB);

Console.WriteLine(Math.Round(distance, 2 , MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2 )
{
    int katet1 = x1 - x2;
    int katet2 = y2 - y1;
    double hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
    return hypo; 
} */