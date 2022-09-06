/* Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
.Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */




int n = 0;
int m = 0;
A(n, m);

Console.Write("Введите число n: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число m: ");
m = Convert.ToInt32(Console.ReadLine());

Console.Write($"-> ");
            
static int A(int n, int m)
    {
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);             
    }
            
    Console.Write(A(n, m));
