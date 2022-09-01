﻿ //Задача 47. Задайте двумерный массив размером m×n, 
 //заполненный случайными вещественными числами.

/* 
m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
  */
 
using System;
namespace CSharp_Shell
{ public static class Program
{ public static void Main()
{ Int32 m, n;
Console.Write("m n: ");
var s = Console.ReadLine().Split(" ");
m = Convert.ToInt32(s[0]);
n = Convert.ToInt32(s[1]);

double[,] a = new double[m, n];

Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
}
}
}
