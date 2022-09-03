// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

GetMatrix(matrix);
Console.WriteLine("Матрица до изменения: ");
PrintArray(matrix);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int z = 0; z < columns - 1; z++)
        {
            if (matrix[i, z] < matrix[i, z + 1])
            {
                int less = 0;
                less = matrix[i, z];
                matrix[i, z] = matrix[i, z + 1];
                matrix[i, z + 1] = less;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Матрица с упорядоченными значениями: ");
PrintArray(matrix);

void GetMatrix(int[,] takeMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}









