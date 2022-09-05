//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

/* Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7 
*/

int[,] array = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
//Console.WriteLine(array.GetLength(0)); // количество строк
//Console.WriteLine(array.GetLength(1)); // длина строки
int summ = 0;


int[] age;
age = new int[array.GetLength(0)];
//array[0, 1]; 

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


for (int i = 0; age[i] == age.Min (); i++)
{
    Console.WriteLine($"минимальная строка: {i}");
}








// Two-dimensional array.
int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
// The same array with dimensions specified.
int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
// A similar array with string elements.
string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };         
//Доступ к элементам массива            
System.Console.WriteLine(array2D[1, 0]);            
            
// Получение общего количества 
//элементов или длины заданного измерения.  

var allLength = array3D.Length;
var total = 1;
for (int i = 0; i < array3D.Rank; i++)
{
    total *= array3D.GetLength(i);
}
System.Console.WriteLine("{0} equals {1}", allLength, total);
            
// Присвоем значение элементу массива
array5[2, 1] = 25;            
            
            
            
            // Определяем длинну массива

int[] numbers = { 1, 2, 3, 5 };
Console.WriteLine(numbers.Length); 



          // Получить элементы массива

int[] numbers = { 7, 5, 3, 4 };
 


    // *получение элемента массива просто инфа

Console.WriteLine(numbers[3]);  // 4
 
    // *получение элемента массива в переменную

var n = numbers[1];     // 5
Console.WriteLine(n);  // 


          //Изменить элемент массива по индексу (второй)

int[] numbers = { 7, 5, 3, 4 };
numbers[1] = 888;  //изменяем на 888
Console.WriteLine(numbers[1]);  // ответ 888


           //Получение элементов с конца массива

int[] numbers = { 1, 2, 3, 5};
Console.WriteLine(numbers[^1]);  // 5 - первый с конца или последний элемент
Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца


            //Перебор массивов и действия с ним


int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] * 8; // умножаем
   Console.WriteLine(numbers[i]);
}

    //* просто перебор массива
int[] numbers = { 1, 2, 3, 4, 5 };
int i = 0;
while(i < numbers.Length)
{
    Console.WriteLine(numbers[i]);
    i++;
}


                //Заполнить массив из пользовательского ввода

class Programm
{
    static void Main(string[] args)
    {

        Console.Write("Введите количество элементов массива:\t ");

        int elementsCount = int.Parse(Console.ReadLine());// читаем данные с консоли

        int[]myArray = new int[elementsCount];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите элемент массива под индексом {i}    :");
            myArray[i] = int.Parse(Console.ReadLine());
        }

         Console.WriteLine("\nВывод массива:");

         for (int i = 0; i < myArray.Length; i++)
         {
            Console.WriteLine(myArray[i]);
         }

    }
}



            // Заполняяем одномерный массаив и находит положительные числа
class Programm
{
    static void Main(string[] args)
    {

        Console.Write("Сколько будет элементов массива?:\t ");

        int elementsCount = int.Parse(Console.ReadLine());// читаем данные с консоли

        int[]myArray = new int[elementsCount];
        int count = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите элемент массива под индексом {i}    :");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nТвой массив:");

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
            if (myArray [i] > 0)// найдем положительное число
            count++;                         
        }


Console.WriteLine("\nВы ввели положительных чисел:");        
Console.WriteLine(count);
    }
}


        // СОЗДАЕМ 2мерный Массив случайными числами
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// Get ссылается на место в массиве
    {
       for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
