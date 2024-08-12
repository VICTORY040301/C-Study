// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

int[] numbers = new int[10] {6, 7, 19, 34, 3, 1, 4, 7, 9, 1};
int counter = 0;
foreach (var number in numbers)
{
    System.Console.Write($"{number} ");
    if (number % 2 == 0)
    {
        counter += 1;
    }
}
 System.Console.Write($"=> {counter}");