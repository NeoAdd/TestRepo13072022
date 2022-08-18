//Напишите метод, который принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int i = 1;
int n = 0;
int result = 0;
n = Convert.ToInt32(Console.ReadLine());

while (i < n+1)
{
      result = i * i * i;
      //Math.Pow(i,i);    // не получается
      i ++;
      Console.WriteLine(result);
}
