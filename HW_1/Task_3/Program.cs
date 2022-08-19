System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.Write("Число " + number + " четное");
}
else {
    System.Console.Write("Число " + number + " нечетное");
}