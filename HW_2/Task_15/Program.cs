// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите цифру одного из дней недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek > 0 && dayOfWeek < 8)
{
    if (dayOfWeek == 6 || dayOfWeek == 7) System.Console.WriteLine($"{dayOfWeek} день недели является выходным");
    else System.Console.WriteLine($"{dayOfWeek} день недели не является выходным");
}
else System.Console.WriteLine($"{dayOfWeek} - дня недели под таким значением не существует");
