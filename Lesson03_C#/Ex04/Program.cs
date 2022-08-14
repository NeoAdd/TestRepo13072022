// СОРТИРОВКА МАССИВА

int[] arr = {4,5,6,8,1,2,7,3,5,8,1,1};


void PrintArray(int[] array) // вывод на экран
{
                      int count = array.Length; // ДЛИННА МАССИВА

                      for (int i  = 0; i < count; i++)
                      {
                                            Console.Write($"{array[i]} ");
                      }
                      Console.WriteLine();
                      
}

void SelectionSort(int[] array)
{
            
            for (int i  = 0; i < array.Lenght -1; i++) // искуственно отнимаем 1, i+1 чтобы работало
            {
                      int minPosition = i;

                      for (int j  = i + 1; j < array.Length; j++) // // ищет максимальный элемент
                      {
                          if(array[j] < array[minPosition]) minPosition = j; // ищет максимальный элемент
                      }

                      int temporary = array [i];
                      array[i] = array[minPosition];
                      array[minPosition] = temporary;

            }          
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);