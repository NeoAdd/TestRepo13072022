// ЦИКЛ for

string Method4(int count,string text)   //count это количество раз
{
                      string result = string.Empty;
                      for (int i = 0; i < count; i++)
                      {
                         result = result + text;
                      }
                     return result;
}

string res = Method4(10, "0_0 ");
Console.WriteLine (res);