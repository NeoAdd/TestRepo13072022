//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

/* Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7 
*/

int[,] array = new int[4, 4] { { 9, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
//Console.WriteLine(array.GetLength(0)); // количество строк
//Console.WriteLine(array.GetLength(1)); // длина строки
int summ = 0;


int[] age;
age = new int[array.GetLength(0)];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
    summ = array[i, j] + summ;
    
   }
  
    //Console.WriteLine($"цикл : {i}");
    Console.WriteLine($"сумма строки {i}: {summ}");
    age[i] = summ;
    summ = 0; 
}
 for (int k = 0; k < array.GetLength(0); k++)
{
    //Console.WriteLine($"найдем сумму массива age : {k}");
    summ = age[k] + summ;
    //Console.WriteLine($"цикл : {k}");
    
}
Console.WriteLine($"Общая сумма: {summ}"); 


 int min = age.Min ();
 Console.WriteLine ($"Min: {min}");

for (int i = 0; age.Min () < age[i]; i++)
{
   
    Console.WriteLine($"минимальная строка: {i}"); // как в примере без учета нулевой строки
}
