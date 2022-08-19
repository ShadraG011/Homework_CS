System.Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (firstNumber > max)
{
    max = firstNumber;
}
if (secondNumber > max)
{
    max = secondNumber;
}
if (thirdNumber > max)
{
    max = thirdNumber;
}

System.Console.WriteLine("Наибольшее число - "  + max);