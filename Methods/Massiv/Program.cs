            // Определяем длинну массива

//int[] numbers = { 1, 2, 3, 5 };
//Console.WriteLine(numbers.Length); 



          // Получить элементы массива

//int[] numbers = { 7, 5, 3, 4 };
 


    // *получение элемента массива просто инфа

//Console.WriteLine(numbers[3]);  // 4
 
    // *получение элемента массива в переменную

//var n = numbers[1];     // 5
//Console.WriteLine(n);  // 


          //Изменить элемент массива по индексу (второй)

//int[] numbers = { 7, 5, 3, 4 };
//numbers[1] = 888;  //изменяем на 888
//Console.WriteLine(numbers[1]);  // ответ 888


           //Получение элементов с конца массива

//int[] numbers = { 1, 2, 3, 5};
//Console.WriteLine(numbers[^1]);  // 5 - первый с конца или последний элемент
//Console.WriteLine(numbers[^2]);  // 3 - второй с конца или предпоследний элемент
//Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца


            //Перебор массивов и действия с ним


//int[] numbers = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = numbers[i] * 8; // умножаем
//   Console.WriteLine(numbers[i]);
//}

    //* просто перебор массива
//int[] numbers = { 1, 2, 3, 4, 5 };
//int i = 0;
//while(i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}


                //Заполнить массив из пользовательского ввода

class Programm
{
    static void Main(string[] args)
    {

        Console.Write("Введите количество элементов массива :\t");

        int elementsCount = int.Parse(Console.ReadLine());

        int[]myArray = new int[elemetsCount];

         Console.WriteLine("Вывод массива: ");

         for (int i = 0; i < myArray.Length; i++)
         {
             Console.WriteLine(myArray[i]);
         }
    }
}