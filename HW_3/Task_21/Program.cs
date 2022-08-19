// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату по X для точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по Y для точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по Z для точки A: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по X для точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по Y для точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по Z для точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());


double distanse = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));

Console.WriteLine($"Расстояние между точками A и B -> {distanse:f2}");
