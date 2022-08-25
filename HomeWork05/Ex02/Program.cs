// Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.

/* [3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

var rnd = new Random();
var set = new HashSet<int>();
var arr = new int[6];
//int count = 0;
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
                      int rand;
                      do
                      {
                                            rand = rnd.Next(-10, 10);
                      } while (set.Contains(rand));
                      set.Add(rand);
                      arr[i] = rand;
                      
                      //if (i % 2 == 0)
                      //count++;
                      //sum = sum + i;
                        sum = arr[1] + arr[3] + arr[5];
                      //Console.WriteLine(arr[i]);
}

foreach (var i in arr)
{

                      Console.Write("{0}  ", i);
}
  
//Console.WriteLine($"Всего четных чисел в массиве ->: {(count)}");
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях ->: {(sum)}");








