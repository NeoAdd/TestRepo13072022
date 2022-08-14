// Методы

// **ПЕРВАЯ ГРУППА**  (не принимаю и не возвращают)
//void Method1()
//{
//                      Console.WriteLine("Автор...");
//}
//Method1(); //скобки обезательны


// **ВТОРАЯ ГРУППА**  (только принимают)

//void Method2(string msg)
//{
//                      Console.WriteLine(msg);
//}
//Method2(msg:"Текст сообщения");


       //Метод выводит именной результат
//void Method21(string msg, int count)
//{
//                     int i = 0;
//                     while (i < count)
//                     {
//                           Console.WriteLine(msg);
//                           i++;
//                     }
//}
// //Method21(msg:"Текст", count: 4);   //первый вариант написания
//Method21(count: 4, msg:"Новый текст");  // второй вариант написания


// **ТРЕТЬЯ ГРУППА**  (только возвращают)


//int Method3()
//{
//                      return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);

// **ЧЕТВЕРТАЯ ГРУППА**  (принимает и возвращают)
string Method4(int count,string text)   //count это количество раз
{
                      int i = 0;
                      //string result =  ""; //Пустая строка
                      string result =  String.Empty;  //Пустая строка

                      while (i < count)
                      {
                                            result = result + text;
                      i ++;
                      }
                      return result;
}

string res = Method4(10, "0_0 ");
Console.WriteLine (res);