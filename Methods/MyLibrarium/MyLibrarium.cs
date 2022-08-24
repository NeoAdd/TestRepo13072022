        // СОЗДАЕМ 2мерный Массив случайными числами
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// Get ссылается на место в массиве
    {
       for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Метод каторый будет заполнять матрицу случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr [i,j] = new Random().Next(1,10);// скобки круглый но [1; 10] это полуиньтерввал
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix); //убеждаюсь что показывает сначало 0
FillArray(matrix);// передадаем наш массив в matrix
Console.WriteLine(); // прослойка между масс
PrintArray(matrix);// снова выводим готовую матрицу с числами






string[,] table = new string[2, 5]; // две строки 5 столбы 
//int[,] matrix = new int[5, 8]; 


//String.Empty  // Иницициализация для строк
// table[0, 0]  table[0, 1]  table[0, 2] table[1, 4] Обращение кстолб
//  table[1, 0]  table[1, 1]  table[1, 2] table[1, 4] Обращение кстолб

// обращение к нужному элементу 1 индекс строки и 2 индекс столбца
table[1, 2] = "слово"; //индексы меняются от 0

for (int rows = 0; rows < 2; rows++)  // rows Счетчик будет называться 
{
                      for (int columns = 0; columns < 5; columns++) //внутр цикл для столб
                      {
                                            Console.WriteLine($"-{table[rows, columns]}-");
                                            // обращаемся к эементу масс через имя table и строки, столб
                      }
}
    
    //Создаем рандомный массив и выводим в одну строку
    
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




//Вводим число и разбиваем на массив а потом суммируем

//using System.Text;
//int value = Convert.ToInt32(Console.ReadLine());
int value = 123;
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

Console.WriteLine($"value складываем массив: {string.Join('+', numbers)}");
Console.WriteLine($"ответ: {(sum)}");



//Вводим число и разбиваем на массив

//using System.Text;
//int value = Convert.ToInt32(Console.ReadLine());
int value = 1234567;
value = Math.Abs(value);

int size = value.ToString().Length;
int[] numbers = new int[size];

while (value != 0)
{
                      numbers[size - 1] = value % 10;
                      value /= 10;
                      //value = value / 10;
                      size--;
}
Console.WriteLine($"value: {string.Join(' ', numbers)}");          
          
          
          
          
           // Сравнить два числа
var a =5;
var b = 6;
if(b > a)
  Console.WriteLine("b больше");
else
  Console.WriteLine("a больше");
           
           
           
           
           
           
           //Метод зеркального отображения числа


//static void Main(string[] args)
        //{
            Console.WriteLine("Число");
            string s = Console.ReadLine();
            char[] str = s.ToCharArray();;
            string a;
            for (int i = str.Length-1; i > -1; --i) 
            {
                a = Convert.ToString(str[i]);
                Console.Write(a);
            }
            Console.ReadKey();
//}


             //метод зеркального отображения числа

int number, result = 0;
    bool neg = false;
 
    Console.Write("Введите число: ");
    //4number = Int32.Parse(Console.ReadLine());
    number = Convert.ToInt32(Console.ReadLine());
 
    if (number < 0) 
    {
        neg = true;
        number *= -1;
    }
 
    while(number > 0)
    {
        result *= 10;
        result += number % 10;
        number /= 10;
    }
 
    if (neg) result *= -1;
    Console.WriteLine(result);


         //Проверка числа на полидром

    int number, result = 0;
    bool neg = false;
int numb;
    Console.Write("Введите число: ");
    //4number = Int32.Parse(Console.ReadLine());
    number = Convert.ToInt32(Console.ReadLine());
    numb = number;
 
    if (number < 0) 
    {
        neg = true;
        number *= -1;
    }
 
    while(number > 0)
    {
        result *= 10;
        result += number % 10;
        number /= 10;
    }
 
    if (neg) result *= -1;

    //Console.WriteLine(result);
    
    if(numb != result)

    Console.WriteLine("нет, не полидром");
    else
    Console.WriteLine("да, полидром");


         // находим квадратный корень и возводим в степень
    Console.Write("Находим расстояние между двумя точками: ");
//int i = 1;
double n = 0;
double result = 0;
n = Convert.ToInt32(Console.ReadLine());



//result = Math.Sqrt(n);  // находим корень
result = Math.Pow(n, n);  // находим степень
Console.WriteLine(result);