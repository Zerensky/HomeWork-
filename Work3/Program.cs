/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Write("Введите число строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[] arr = new int[m];
int sum = 0;

void Array(int[,] matrix)
{
    for (int i = 0; i < n; i++)
    { 
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
            Console.Write(matrix[i, j] + " \t"); 
        } 
        Console.WriteLine(); 
    } 

    for (int j = 0; j < m; j++)
    { 
        for (int i = 0; i < n; i++)
        { 
            sum += matrix[i, j];
            arr[j] = sum; 
        } 
        sum = 0;
    } 
}

Array(matrix);
Console.WriteLine();
Console.WriteLine(string.Join(" \t", arr));
