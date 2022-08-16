/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет    */ 

Console.WriteLine("Введите число строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[m, n];

void PrintArray(double[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
            matrix[i, j] = new Random().Next(0, 100);
            Console.Write(matrix[i, j] + " \t"); 
        } 
    Console.WriteLine(); 
    } 
} 
PrintArray(matrix);
Console.WriteLine();

if (a > m || b > n)
    Console.WriteLine("Такого числа в массиве нет"); 
else 
    Console.Write(matrix[a - 1, b - 1]);












// Console.Write("Введите номер строки: ");
// int n = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.WriteLine();
// Console.Write("Введите номер столбца: ");
// int m = Convert.ToInt32(Console.ReadLine()) - 1;
// int[,] matrix = new int[m, n];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// matrix[i, j] = new Random().Next(-10,10);
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// Console.Write(matrix[i, j] + " \t");
// Console.WriteLine();
// }
// if ((n >= 0 && n < matrix.GetLength(0)) && (m >= 0 && n < matrix.GetLength(1)))
// Console.WriteLine();
// {
// else 
// Console.WriteLine("No"); 
// }

