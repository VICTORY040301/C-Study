//  Напишите программу, которая на вход принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

System.Console.Write("Write a natural number: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{N} => ");

int[] arr = new int[N];
int j = 0;

while (N > 0)
{
    int current = N % 10;
    arr[j] = current;
    // System.Console.Write($"{arr[j]}, ");
    j++;
    N = N / 10;
}
int i = arr.Length;
for (i = arr.Length - 1; i > -1; i--)
{
    if (arr[i] == 0)
    {
        i--;
    }
    else
    {
        System.Console.Write($"{arr[i]}, ");
    }
}
