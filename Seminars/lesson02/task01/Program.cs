// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую 
// цифру этого числа.
// Примеры
// a = 256 => 26 
// a = 891 => 81

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int leftDigit = number / 100;
    int rigthDigit = number % 10;
    int result = leftDigit * 10 + rigthDigit;
    System.Console.WriteLine(result);
}
else
{
    Console.Write("Число не трёхзначное!!!");
}