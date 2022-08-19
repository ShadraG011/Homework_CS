// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0) size *= (-1);

int[] array = new int[size];
int amount = 0;

for (int i = 0; i < size; i++)
    array[i] = new Random().Next(100);

for (int i = 1; i < size; i += 2)
    amount = amount + array[i];

Console.WriteLine($"Массив целых чисел: [{String.Join("; ", array)}]");
Console.WriteLine($"Сумма чисел на  нечетных позициях: {amount}");