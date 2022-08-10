// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 44;
int b = 5;
int c = 78;
int summ = a + b + c; 

while (summ > a && summ > b && summ > c )
{
                      
summ--; 

}

Console.WriteLine( summ );

//for (int summ = a + b + c ; summ > c || summ > b || summ > b ; summ-- ) 
//{ 
      //if (summ == a || summ == b || summ == c);
      //{
      //        Console.WriteLine( summ );        
      //}              
//Console.WriteLine( summ );
//}
//else 
//{
//int summ = summ - 1 ;
//}
   //Console.WriteLine($" {summ} - min,  {summ} - max");                  

//return "" ;