﻿//Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
/* 
M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8"" */

Console.Write("Введите число N: ");
int N = 0;
int M = 0;

N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
M = Convert.ToInt32(Console.ReadLine());

Console.Write($"-> ");
Console.Write($"{(N)}");
while (N < M)
{
      N ++;
      Console.Write($", ");
      Console.Write($"{(N)}");
}


