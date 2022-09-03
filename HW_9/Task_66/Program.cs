// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите первое число промежутка: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число промежутка: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= M)
{
    int SumNumbers(int M, int N)
    {
        if (M == N) return M;
        return (M + SumNumbers(M + 1, N));
    }
    Console.WriteLine($"\nСумма чисел в промежутке от {M} до {N}: {SumNumbers(M, N)}\n");
}
else Console.WriteLine("Первое число должно быть меньше чем второе");