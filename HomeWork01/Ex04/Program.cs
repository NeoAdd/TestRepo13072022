// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

int n;
int bank = 1;

Console.WriteLine("Введите число быстрее: ");
n = Convert.ToInt32(Console.ReadLine());

// n = Console.Read ();
//do
while (bank < n)
{
                     Console.WriteLine( bank++ );
                     // bank = bank + 1;
}
//while (bank > N);
                      //Console.WriteLine( i );
Console.WriteLine( bank );