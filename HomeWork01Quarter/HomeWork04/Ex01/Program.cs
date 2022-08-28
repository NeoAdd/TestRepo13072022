// Задача 25: Напишите метод, который принимает
// на вход два числа (A и B) и возводит число A в натуральную степень B.
//нельзя использовать pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число N1: ");
int i = 0;
int n1 = 0;
int n2 = 0;
int result = 0;
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N2: ");
n2 = Convert.ToInt32(Console.ReadLine());

while (i < 1)
{
                      result = n1 * n1;
                      i++;
                      
}
while (i < n2-1)
{
                      result = result * n1;
                      i++;
                      
}
Console.WriteLine(result);