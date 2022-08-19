System.Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    System.Console.WriteLine(firstNumber + " - наибольшее число");
    System.Console.WriteLine(secondNumber + " - наименьшее число");
}
else {
    System.Console.WriteLine(secondNumber + " - наибольшее число");
    System.Console.WriteLine(firstNumber + " - наименьшее число");
}
