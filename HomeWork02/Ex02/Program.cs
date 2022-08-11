// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

int valuet1 = 64; 
//int valuet2 = 78;
//int valuet3 = 32679;


int result1 = valuet1 / 10 / 10 % 10;  
//int result2 = valuet2 / 10 / 10 % 10;
//int result3 = valuet3 / 10 / 10 % 10;

 if (result1 < 1) 
 {
                Console.WriteLine($" {valuet1} ->>получаем число {result1}");      
 }
else if (result1 < 0 ) 
{
Console.WriteLine($" {valuet1} ->> третьей цифры нет");
}

//Console.WriteLine($" {valuet2} ->>получаем число {result2}");
//Console.WriteLine($" {valuet3} ->>получаем число {result3}");