// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите количество чисел: ");
int quantityNumber = Convert.ToInt32(Console.ReadLine());
int[] seriesNumber = new int [quantityNumber];
int count= 0;

for (int i = 0; i < quantityNumber; i++)
{
    Console.Write("Введите число: ");
    seriesNumber[i] = Convert.ToInt32(Console.ReadLine());
    if (seriesNumber[i] > 0) count ++;
    
}

Console.Write( $"{String.Join(" , ", seriesNumber)} -> количество чисел больше нуля - {count}");
