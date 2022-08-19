// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите  трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int remains = num % 100;
    int secondNum = remains / 10;
    System.Console.WriteLine($"Вторая цифра числа {num} = {secondNum}");
}
else {
    System.Console.WriteLine("Вы ввели не трехзначное число");
}