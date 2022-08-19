// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum (int num)
{
    int result = 0;
    int res = 0;

    while(num > 0)
    {
        res = num % 10;
        result += res;
        num /= 10;
    }
    return result;
}
if (num >= 0) Console.WriteLine($"Сумма цифр в числе {num} = {Sum(num)}");
else Console.WriteLine("Error");