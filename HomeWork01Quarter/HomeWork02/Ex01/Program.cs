// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа. 456.782.918

Console.WriteLine("программа вывода второй цыфры в трехзначном числе");
int valuet1 = 456; // можно использовать double
int valuet2 = 782;
int valuet3 = 918;

int result1 = valuet1 / 10 % 10;  // % символ для деление с остатком
int result2 = valuet2 / 10 % 10;
int result3 = valuet3 / 10 % 10;

// Console.WriteLine(result);
//$ Включает {} все что в них будет включаться в работу
Console.WriteLine($" {valuet1} ->>получаем число {result1}");
Console.WriteLine($" {valuet2} ->>получаем число {result2}");
Console.WriteLine($" {valuet3} ->>получаем число {result3}");