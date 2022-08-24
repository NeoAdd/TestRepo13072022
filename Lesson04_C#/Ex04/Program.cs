    // ФИБОНАЧИ  (каждое следующее число равно сумме двух предыдущих)

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci (int n)
{
    if(n == 1  || n == 2) return 1; // если т=1 или n=2 возвращеем 1
    else return Fibonacci(n-1) + Fibonacci(n-2); //тогда ворачиваем значение
}

for (int i = 1; i < 50; i++)
{
    //Console.WriteLine(Fibonacci(i));
    Console.WriteLine($"f({i}) = {Fibonacci(i)}"); // для демонстрации 
}


