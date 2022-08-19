System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int even = 0;

System.Console.Write("Ряд четных чисел: ");
while (even < number)
{
    even++;
    if (even % 2 == 0)
    {
        System.Console.Write(even + " ");
    }
}
