// Задача 27: Напишите матод, который принимает на вход 
//число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System.Text;
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

value = Math.Abs(value);

int size = value.ToString().Length;
int[] numbers = new int[size];
int sum = 0;
while (value != 0)
{
                      numbers[size - 1] = value % 10;
                      value /= 10;
                      size--;
                     
}
 for (int i = 0; i < numbers.Length; i++)
                      {
                                            Console.WriteLine(sum);
                                            sum = sum + numbers[i];
                      }

Console.WriteLine($"Складываем массив: {string.Join('+', numbers)}");
Console.WriteLine($"Ответ: {(sum)}");
