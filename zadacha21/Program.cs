// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double DistanceBetweenPoints(double ax, double ay, double az, double bx, double by, double bz)
{
    double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    return distance;
}

Console.WriteLine("Введите значение X у первой точки");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y у первой точки");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z у первой точки");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение X у второй точки");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y у второй точки");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z у второй точки");
int bz = Convert.ToInt32(Console.ReadLine());

double distanceBetweenPoints = DistanceBetweenPoints(ax, ay, az, bx, by, bz);
Console.WriteLine($"{distanceBetweenPoints:f2}");
