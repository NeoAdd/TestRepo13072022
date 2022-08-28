//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и 
//минимальным элементов массива.

//[3 7 22 2 78] -> 76


var rnd = new Random();
var set = new HashSet<int>();
var arr = new int[6];

int sum = 0;
int min = 0;
int max = 0;
for (int i = 0; i < arr.Length; i++)
{
    int rand;
    do
    {
        rand = rnd.Next(0, 100);
    } while (set.Contains(rand));
    set.Add(rand);
    arr[i] = rand;
                      
    if (rand < max)
    {
        min = rand;
    }
    else
    {
       max = rand;
    }  

}

foreach (var i in arr)
{

    Console.Write("{0}  ", i);
}

Console.WriteLine($"минимальное в массиве {min}, Максимальное в массиве {max}");
Console.WriteLine($"Разница между  min и max: {sum = max-min}");













