// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble();
    array[i] = array[i] * 100;
}

double max = 0;
double min = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.Write("Массив вещественных чисел: ");
for (int i = 0; i < size; i++)
{
    Console.Write(Math.Round(array[i], 0) + "; ");
}
Console.WriteLine($"\nРазница между максимальным  \"{Math.Round(max, 0)}\" и минимальным числом \"{Math.Round(min, 0)}\" элементоми  массива = {Math.Round((max - min), 0)}");