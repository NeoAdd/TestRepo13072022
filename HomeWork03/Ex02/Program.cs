// Задача 21
//Напишите метод, который принимает на вход 
//координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//     A (3,6,8); B (2,1,-7), -> 15.84
//     A (7,-5, 0); B (1,-1,9) -> 11.53

// √((x2-x1)^2 )+(y2-y1)^2+(z2-z1)^2

Console.Write("Находим расстояние между двумя точками: ");
//int i = 1;
double Ax = 3;
double Ay = 6;
double Az = 8;

double Bx = 2;
double By = 1;
double Bz = -7;
double result ;
double result1 ;
double result2 ;
double result3 ;

// находим степень
result1 = Math.Pow((Bx - Ax), 2);
result2 = Math.Pow((By - Ay), 2);
result3 = Math.Pow((Bz - Az), 2);

// находим корень
result = Math.Sqrt(result1 + result2 + result3);  

Console.WriteLine(result);

