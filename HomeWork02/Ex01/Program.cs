// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа. 456.782.918

Console.WriteLine("программа вывода первой цыфры после запятой");
int valuet1 = 456; // можно использовать double
int valuet2 = 555;
int valuet3 = 777;

int result1 = valuet1 % 100; // % символ для деление с остатком
int result2 = valuet2 % 10;
int result3 = valuet3 % 10;
// Console.WriteLine(result);
//$ Включает {} все что в них будет включаться в работу
Console.WriteLine($" {valuet1} ->>получаем число {result1}");
Console.WriteLine(result2);
Console.WriteLine(result3);