Console.Write("Введите координаты X первой точки: ");
int XA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты Y первой точки: ");
int YA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты X второй точки: ");
int XB = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координаты Y второй точки: ");
int YB = int.Parse(Console.ReadLine() ?? "");

double result = Math.Sqrt(Math.Pow(XA - XB, 2) + Math.Pow(YB - YA, 2));
result = Math.Round(result, 2);

Console.WriteLine($"A ({XA},{YA}); B ({XB},{YB}) -> {result}");