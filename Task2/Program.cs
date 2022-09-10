// Найти расстояние между двумя точками в 3Д пространстве по введенным координатам

double GetDistance3d(double xa, double xb, double ya, double yb, double za, double zb)
{
    double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    return distance;
}


System.Console.WriteLine("Введите координаты X первой точки: ");
double x1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты X второй точки: ");
double x2 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты Y первой точки: ");
double y1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты Y второй точки: ");
double y2 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты Z первой точки: ");
double z1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты Z второй точки: ");
double z2 = double.Parse(Console.ReadLine());

double resultDistance = Math.Round(GetDistance3d(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Расстояние между двумя точками равно {resultDistance}");

Console.ReadLine();


