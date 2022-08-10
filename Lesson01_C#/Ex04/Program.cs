// Задача из семинара
//Console.WriteLine("Программа для нахождения целых чисел в промежутке от положительного и отрицательного");
Console.Write("Введите число: ");
//int value = Convert.ToInt32(Console.Readline());
int value = 4;
int count = value * (-1);

while(count <= value) // знак ; не ставим
{
Console.WriteLine (count);
count++;
}
