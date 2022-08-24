            //  // СОЗДАЕМ 2мерный Массив случайными числами

            
// НОМЕНКЛАТУРА 
// int тип данных [,] matrix имя = присвоим new и тип данных int[сколько нужно строк, и столбиков]
//              matr.GetLength(0) - укажет количество строк
//              matr.GetLength(0) - укажет количество столб


/* string[,] table = new string[2, 5]; // две строки 5 столбы 
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
 */


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