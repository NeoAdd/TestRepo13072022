//int a;

//Console.WriteLine(" Введите число: ");
//a = Convert.ToInt32(Console.ReadLine());

//int b = 6;
//if(b != a)
//  Console.WriteLine("не полидром");
//else
//  Console.WriteLine("да полидром");


int number, result = 0;
    bool neg = false;
 
    Console.Write("Введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
 
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

    Console.WriteLine(result);
    //Console.WriteLine(number);

    //if(number != result)

    //Console.WriteLine("не полидром");
    //else
    //Console.WriteLine("да полидром");


