// РЕКУРСИЯ

double Factorial (int n)  // Можно тип данных поменять Double  или int
{
    //если дошли 1 то вернем 1
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;

    //если не 1 тогда
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    //Console.WriteLine(Factorial(i));  // i для запуска цикла
    Console.WriteLine($"{i}! = {Factorial(i)}"); // Для демонстрации  какой факт считает
}
//System.Console.WriteLine(Factorial(3)); //1*2*3 = 6 // можно сдесь изменить 3 на 5




