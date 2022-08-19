// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите длину массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
int size = array.Length;
int count = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine($"Массив целых чисел: [{String.Join("; ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве: {count}");
