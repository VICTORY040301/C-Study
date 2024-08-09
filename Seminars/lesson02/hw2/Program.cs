//  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
// 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4
System.Console.WriteLine("Please, read before use. The requirement for input numbers:");
System.Console.WriteLine("1. only INTEGERS,");
System.Console.WriteLine("2. NOT ZERO.");


System.Console.Write("Write X: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Write Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Please, CHECK the entered data. Y may wrote zero.");
}
else
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine($"{x}, {y} => 1");
    }
    if (x > 0 && y < 0)
    {
        System.Console.WriteLine($"{x}, {y} => 4");
    }
    if (x < 0 && y < 0)
    {
        System.Console.WriteLine($"{x}, {y} => 3");
    }
    if (x < 0 && y > 0)
    {
        System.Console.WriteLine($"{x}, {y} => 2");
    }
}