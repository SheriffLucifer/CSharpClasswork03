Console.Write("Введите четверть системы коорлдинат от 1 до 4: ");
int quarter = int.Parse(Console.ReadLine() ?? "");

if (quarter == 1)
{
    Console.WriteLine("Координаты X > 0 и Y > 0");
}
else if (quarter == 2)
{
    Console.WriteLine("Координаты X < 0 и Y > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("Координаты X < 0 и Y < 0");
}
else if (quarter == 4)
{
    Console.WriteLine("Координаты X > 0 и Y < 0");
}
else
{
    Console.WriteLine("Вы ошиблись! Такой четверти нет");
}