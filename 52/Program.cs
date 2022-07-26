/*
Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] InitMatrix(int m, int n)
{
    int [,] matrix = new int [m,n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = randomizer.Next (1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Average (int[,] matrix)
{   
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
    double result = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, i];
    }
    result = Math.Round(result / matrix.GetLength(0), 1);
    
   Console.WriteLine($"Среднее арифметическое в столбце № {i+1} = {result}");
    }
}

Console.WriteLine("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());

int [,] matrix = InitMatrix(m, n);

PrintMatrix(matrix);
Console.WriteLine();
Average(matrix);


