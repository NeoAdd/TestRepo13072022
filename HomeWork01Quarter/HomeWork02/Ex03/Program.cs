﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

int a;
int day6 = 6;
int day7 = 7;

Console.WriteLine(" Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
if ( a == day6 || a == day7 )  // ошибка, вылетает с цикла
{
                      Console.WriteLine("ответ Да ");
}
else 

{
                      Console.WriteLine( "ответ Нет ");    
}