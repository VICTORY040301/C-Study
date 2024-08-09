// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23
// a=50 => нет
// a=7 => нет
// a=322 => да

System.Console.Write("Write number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
    System.Console.WriteLine($"a={a} => yes");
}
else
{
    System.Console.WriteLine($"a={a} => no");
}