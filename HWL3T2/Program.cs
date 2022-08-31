double Distance()
{
   Console.WriteLine("Введите координату x точки 1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки 1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки 1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x точки 2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки 2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки 2 ");
int z2 = Convert.ToInt32(Console.ReadLine());
    double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return result;
}

Console.WriteLine($"Расстояние между точкой 1 и точкой 2 -> {Distance()}");
