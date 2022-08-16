// Напишите метод, который принимает на вход 
// шестизначное число и проверяет, 
// является ли оно палиндромом

int number, result = 0;
    bool neg = false;
int numb;
    Console.Write("Введите число: ");
    //4number = Int32.Parse(Console.ReadLine());
    number = Convert.ToInt32(Console.ReadLine());
    numb = number;
 
    if (number < 0) 
    {
        neg = true;
        number *= -1;
    }
 
    while(number > 0)
    {
        result *= 10;
        result += number % 10;
        number /= 10;
    }
 
    if (neg) result *= -1;

    //Console.WriteLine(result);
    
    if(numb != result)

    Console.WriteLine("нет, не полидром");
    else
    Console.WriteLine("да, полидром");

