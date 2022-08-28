





//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

var rnd = new Random();
var set = new HashSet<int>();
var arr = new int[4];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
                      int rand;
                      do
                      {
                                            rand = rnd.Next(100, 999);
                      } while (set.Contains(rand));
                      set.Add(rand);
                      arr[i] = rand;
                      
                      if (rand % 2 == 0)
                      count++;
}

foreach (var i in arr)
{

                      Console.Write("{0}  ", i);
}
  
Console.WriteLine($"Всего четных чисел в массиве ->: {(count)}");
