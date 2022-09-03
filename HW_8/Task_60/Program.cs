// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Введите количество цифр по X: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество цифр по Y: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество цифр по Y: ");
int layers = Convert.ToInt32(Console.ReadLine());
int[,,] matrix3D = new int[rows, columns, layers];

GetMatrix(matrix3D);
PrintMatrix(matrix3D);
Console.WriteLine();

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("| ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) | ");
            }
            Console.WriteLine();
        }
    }
}

void GetMatrix(int[,,] matrix3D)
{
    int[] array = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int number;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);
        number = array[i];
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 100);
                    j = 0;
                    number = array[i];
                }
                number = array[i];
            }
        }
    }
    
    int count = 0;
    for (int x = 0; x < matrix3D.GetLength(0); x++)
    {
        for (int y = 0; y < matrix3D.GetLength(1); y++)
        {
            for (int z = 0; z < matrix3D.GetLength(2); z++)
            {
                matrix3D[x, y, z] = array[count];
                count++;
            }
        }
    }
}
