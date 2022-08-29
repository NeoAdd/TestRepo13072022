// Задача 43: Напишите программу, которая найдёт 
//точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)//




Console.WriteLine("Находим точку пересечения двух прямых");
Console.WriteLine("Введите значения b1: ");

double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double result = 0;
double result1 = 0;

result = (b2 - b1) / (k1 - k2);
result1 = k1 * result + b1;

Console.WriteLine($" точка пересечения({result} ; {result1})");

/* if (result1 == result)
{
    Console.WriteLine("прямые не пересекаются: ");
}
 */