// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число для преобразования его в двоичный код: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (number == 0) Console.WriteLine($"Двоичный код: [0]");
else
{
    int[] reverseBinaryArray = new int[number];
    while (number / 2 != 0)
    {
        reverseBinaryArray[i] = number % 2;
        number /= 2;
        i++;
    }
    reverseBinaryArray[i] = number % 2;

    int[] binaryArray = new int[i + 1];
    for (int j = 0; j < binaryArray.Length; j++)
    {
        binaryArray[j] = reverseBinaryArray[i];
        i--;
    }
    Console.Write($"Двоичный код: [{String.Join("", binaryArray)}]");
}



