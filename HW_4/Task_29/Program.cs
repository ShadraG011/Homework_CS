// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int size)
{
    int[] arrayElement = new int[size];
    for (int i = 0; i < arrayElement.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        arrayElement[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrayElement;
}
Console.Write("Введите длину массива: ");
int[] array = GetArray(Convert.ToInt32(Console.ReadLine())); 
Console.WriteLine($"Результат: [{String.Join("; ", array)}]");   

 
