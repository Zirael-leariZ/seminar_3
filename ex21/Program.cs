// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Z2: ");
int z2 = int.Parse(Console.ReadLine());

int dx = (x2 - x1) * (x2 - x1);

int dy = (y2 - y1) * (y2 - y1);

int dz = (z2 - z1) * (z2 - z1);

double result = Math.Sqrt(dx + dy + dz);

Console.WriteLine($"{result:0.00}");
// Console.WriteLine(Math.Round(result, 2));