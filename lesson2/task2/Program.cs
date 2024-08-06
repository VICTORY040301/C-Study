// Создать массив и заполнить его целыми 
// числами от 1 до N (N – произвольное 
// натуральное число). Вывести элементы 
// массива на экран.

Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i = i + 1;
}