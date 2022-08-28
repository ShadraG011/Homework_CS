// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    // double col = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
    return matrix;
}

void AverageNumbers(int[,] array)
{
    double[] sumArray = new double[columns];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumArray[i] += array[j, i];
        }
    }

    for (int i = 0; i < columns; i++)
    {
        sumArray[i] /= rows;
        Console.Write(Math.Round(sumArray[i], 1) + "; ");
    }
}

Console.WriteLine($"Матрица:");
int[,] resultMatrix = GetArray(rows, columns);
Console.Write("Среднее арифметическое каждого столбца: ");
AverageNumbers(resultMatrix);