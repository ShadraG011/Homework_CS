// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
Console.Write("Введите индекс m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && (n == 0)) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
Console.Write($"Функция Аккермана = {AkkermanFunction(m, n)}");
