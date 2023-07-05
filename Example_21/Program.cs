// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.

Console.WriteLine("Введите данные первой точки по оси oX: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные первой точки по оси oY: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные первой точки по оси oZ: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите данные второй точки по оси oX: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные второй точки по оси oY: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные второй точки по оси oZ: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);

Console.WriteLine($"Дистанция между заданными точками {d}");


