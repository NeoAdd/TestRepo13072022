//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:

/* 
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 
*/

int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

//Console.WriteLine(array.Length[3]);

Console.WriteLine(array.GetLength(0)); // количество строк
Console.WriteLine(array.GetLength(1)); // длина строки




/* int summ0 = 0;
int summ1 = 0;
 */

array[0, 1] = 25;
System.Console.WriteLine(array[0, 1]); 




//Изменить элемент массива по индексу (второй)

/* int[] numbers = { 7, 5, 3, 4 };
numbers[1] = 888;  //изменяем на 888
Console.WriteLine(numbers[1]);  // ответ 888
Console.WriteLine(numbers[0]);
 */