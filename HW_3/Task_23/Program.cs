// Задача 23. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int even = 1; even <= num; even++)
{
    Console.WriteLine($"Число {even} возведенное в куб = {Math.Pow(even, 3)}");

}

// Console.Write("Ряд чисел от 1 до N в кубе: " + "\t");
// for (int even = 1; even <= num; even++)
// {
//     Console.Write(Math.Pow(even, 3) + "\t");
// }