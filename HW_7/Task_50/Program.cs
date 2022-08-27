// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
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

void NumberMatrix(int[,] findNumber)
{
    Console.Write("Введите индекс строки: ");
    int indexRow = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите индекс столбца: ");
    int indexColumn = Convert.ToInt32(Console.ReadLine());
    
    int number = 0;
    bool a = false;

    for (int i = 0; i < findNumber.GetLength(0); i++)
    {
        for (int j = 0; j < findNumber.GetLength(1); j++)
        {
            if (indexRow == i && indexColumn == j) 
            {
                number = findNumber[i, j];
                a = true;
            }
        }
    }
    Console.WriteLine();
    if (a) System.Console.WriteLine($"Число с индексом строки {indexRow} и индексом столбца {indexColumn} = {number}");
    else System.Console.WriteLine($"Числа с индексом строки {indexRow} и индексом столбца {indexColumn} НЕТ");
}

Console.WriteLine($"Матрица размером {rows} на {columns}:");
int[,] resultMatrix = GetMatrix(rows, columns);
Console.WriteLine();
NumberMatrix(resultMatrix);