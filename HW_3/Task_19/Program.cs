// Задача 19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число состоящее из 5 цифр: ");
int num = Convert.ToInt32(Console.ReadLine());
string Num = Convert.ToString(num);

if (Num.Length == 5)
{
    if (Num[0] == Num[4] && Num[1] == Num[3]) Console.WriteLine($"Число {num} является полиндромом");
    else Console.WriteLine($"Число {num} не является полиндромом");
}
else Console.WriteLine("Ошибка: вы ввели число не состоящее из 5 цифр.");
