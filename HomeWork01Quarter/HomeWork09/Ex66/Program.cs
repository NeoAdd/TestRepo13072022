//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

/* M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */




Console.Write("Введите число N: ");
int N = 0;
int M = 0;
int sum = 0;
N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
M = Convert.ToInt32(Console.ReadLine());

Console.Write($"-> ");
while (N < M+1)
{
    sum = sum + N;
    N ++;
   }
Console.Write($"{(sum)}");
