﻿// Создать целочисленный массив на 10 
// элементов и заполнить его произвольными 
// числами. Вывести на экран чётные элементы 
// массива.


int[] array = { 2, 3, 4, 5, 5, 8, 9 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}