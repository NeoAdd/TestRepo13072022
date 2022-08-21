//Напишите метод, который задаёт массив из 
//8 элементов (диапазон от 1 до 100) и выводит их на экран.
//пример вывода
//[1,4,5,3,1,2,3,9]
//[4,45,53,31,14,25,63,19]

var rnd = new Random();
var set = new HashSet<int>();
var arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
                      int rand;
                      do
                      {
                                            rand = rnd.Next(100);
                      } while (set.Contains(rand));
                      set.Add(rand);
                      arr[i] = rand;
}

foreach (var i in arr)
{
                      Console.Write("{0} ", i);
}
  Console.WriteLine( "Массив");