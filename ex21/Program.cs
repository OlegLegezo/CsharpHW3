// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("задайте координату Х первой точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("задайте координату У первой точки: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("задайте координату Z первой точки: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("задайте координату Х второй точки: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("задайте координату У второй точки: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("задайте координату Z второй точки: ");
double z2 = double.Parse(Console.ReadLine());

double x = x2 - x1;
double y = y2 - y1;
double z = z2 - z1;

double answer = Math.Sqrt(x * x + y * y + z * z);

Console.WriteLine("{0:0.00}",answer);