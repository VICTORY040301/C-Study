// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого 
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

System.Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int secondDigit = number / 10 % 10;
    int square = number % 10;
    int power = 1;
    for (square = number % 10; square > 0; square--)
    {
        power = power * secondDigit;
    }

    Console.Write(power);
}
else
{
    Console.Write("Число не трёхзначное!!!");
}