// Лекция 6

using System.Linq; // дополнительный модуль

string text = "(1,2) (2,3) (4,5) (5,6)";
                //.Replace("(", "")
                //.Replace(")", "")
                //;
//Console.WriteLine(text);



var data = text.Split(" ") // метод Split для разбивки сивола разделителя
                .Select(item => item.Split(','))
                .ToArray();


for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data [i]);
}







