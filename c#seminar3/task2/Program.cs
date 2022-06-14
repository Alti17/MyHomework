double FindLength(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB-yA),2) + Math.Pow((zB-zA),2));
}

Console.Write("Введите координаты точки А по оси х: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки А по оси y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки А по оси z: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B по оси х: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B по оси y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B по оси z: ");
double zB = Convert.ToDouble(Console.ReadLine());
double result = FindLength(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками А и В равно: {result}.");