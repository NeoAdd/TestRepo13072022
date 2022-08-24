string[,] table = new string[2, 5]; // две строки 5 столбы 
//int[,] matrix = new int[5, 8]; 


//String.Empty  // Иницициализация для строк
// table[0, 0]  table[0, 1]  table[0, 2] table[1, 4] Обращение кстолб
//  table[1, 0]  table[1, 1]  table[1, 2] table[1, 4] Обращение кстолб

// обращение к нужному элементу 1 индекс строки и 2 индекс столбца
table[1, 2] = "слово"; //индексы меняются от 0

for (int rows = 0; rows > 2; rows++)  // rows Счетчик будет называться 
{
     for (int columns = 0; columns<5; columns++) //внутр цикл для столб
{
           Console.WriteLine($"{table[rows, columns]}");
           // обращаемся к эементу масс через имя table и строки, столб
}
}