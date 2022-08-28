 //ЦИКЛ for

string Method4(int count,string text)   //count это количество раз
{
                     string result = string.Empty;
                      for (int i = 0; i < count; i++)
                      {
                         result = result + text;
                      }
                     return result;
}

string res = Method4(10, "0_0 "); // 10 раз подряд фраза
Console.WriteLine (res);

//      **ТАБЛИЦА УМНОЖЕНИЯ**

for (int i = 2; i <= 10; i++)
{
                      for (int j = 2; j <= 10; j++)
                      {
                      Console.WriteLine ($"{i} x {j} = {i * j}");          
                      }
                      Console.WriteLine ();
}