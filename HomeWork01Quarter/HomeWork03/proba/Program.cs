Console.Write("Введите количество элементов массива ");

int elementsCount = int.Parse(Console.ReadLine());
int[]myArray = new int[elementsCount];

         //Console.WriteLine("Вывод массива: ");

         for (int i = 0; i < myArray.Length; i++)
         {
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myArray[i]);
         }
