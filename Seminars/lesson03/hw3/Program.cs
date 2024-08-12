// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

double[] numbers = {2.2, 0.4, 9.11, 7.2, 78.98}; 
double max = numbers[i];
double min = numbers[i];

foreach (var number in numbers)
{
    System.Console.Write($"{number} ");
}
int i = 0;
for (int i = 1; i < numbers.Length - 1; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

double diff = max - min;
System.Console.Write($"=> {diff}");