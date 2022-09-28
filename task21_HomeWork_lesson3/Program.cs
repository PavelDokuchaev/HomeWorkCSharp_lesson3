/*
Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double distanceAB()
{
    Console.WriteLine("Точка 1 координата Х");
    int coordinateAX= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координата У");
    int coordinateAY = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координата Z");
    int coordinateAZ = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Точка 2 координата Х");
    int coordinateBX= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координата У");
    int coordinateBY = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координата Z");
    int coordinateBZ = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow(coordinateAX - coordinateBX, 2) + 
    Math.Pow(coordinateAY - coordinateBY, 2) + Math.Pow(coordinateAZ - coordinateBZ, 2));
    return result;
}

double result = distanceAB();
result = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками А и В в 3D пространстве равно {result}");
