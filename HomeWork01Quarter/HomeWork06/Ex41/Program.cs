//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* 0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


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
