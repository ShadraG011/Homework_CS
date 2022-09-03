// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];

Console.Write("Введите количество строк: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] secondMatrix = new int[rows2, columns2];

if (columns == rows2)
{
    GetMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    GetMatrix(secondMatrix);
    PrintMatrix(secondMatrix);
    Console.WriteLine();
    int[,] resultMatrixsMultiply = MultiplyMatrixs(matrix, secondMatrix);
    PrintMatrix(resultMatrixsMultiply);
}
else Console.WriteLine("\nУмножение матриц не возможно");

void GetMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write((i + 1) + ") ");
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("]");
    }
}

int[,] MultiplyMatrixs(int[,] matrix, int[,] secondMatrix)
{
    int[,] resultMultiplyMatrixs = new int[rows2, columns2];
    for (int i = 0; i < resultMultiplyMatrixs.GetLength(1); i++)
    {
        for (int j = 0; j < resultMultiplyMatrixs.GetLength(0); j++)
        {
            int sumMultiply = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sumMultiply += matrix[j, k] * secondMatrix[k, i];
            }
            resultMultiplyMatrixs[j, i] = sumMultiply;
        }
    }
    return resultMultiplyMatrixs;
}