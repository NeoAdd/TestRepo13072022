//Вводим число и разбиваем на массив

//using System.Text;
//int value = Convert.ToInt32(Console.ReadLine());
int value = 1234567;
value = Math.Abs(value);

int size = value.ToString().Length;
int[] numbers = new int[size];

while (value != 0) ;
{
                      numbers[size - 1] = value % 10;
                      value /= 10;
                      size--;
}
Console.WriteLine($"value: {string.Join(' ', numbers)}");