//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7
System.Console.WriteLine("Please, read before use. The requirement for input numbers:");
System.Console.WriteLine("1. only INTEGERS,");
System.Console.WriteLine("2. [10, 99].");

System.Console.Write("Write INTEGES number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int firstN = number / 10;
    int secondN = number % 10;
    if (firstN > secondN)
    {
        System.Console.WriteLine($"{number} => {firstN}");
    }
    else
    {
        System.Console.WriteLine($"{number} => {secondN}");
    }
}
else
{
    System.Console.Write("Please, check the correctness of the entered number!!!");
}