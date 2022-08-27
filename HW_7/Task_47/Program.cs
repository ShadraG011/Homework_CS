// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] doubleMatrix = new int[rows, columns];

Console.WriteLine("Матрица вещественных чисел:");
for (int i = 0; i < doubleMatrix.GetLength(0); i++)
{
    for (int j = 0; j < doubleMatrix.GetLength(1); j++)
    {
        doubleMatrix[i, j] = new Random().Next(-99, 100);
        Console.Write(Math.Round(Convert.ToDouble(doubleMatrix[i, j] * 0.1), 1) + "\t");
    }
    Console.WriteLine();
}