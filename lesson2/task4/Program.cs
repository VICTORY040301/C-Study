// Дано N гирь с разным весом в случайном 
// порядке. Определить вес самой тяжелой 
// гири.

int[] array = {1,4,3,2,6,2};
int i = 0;
int max = array[0];

while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);

foreach (int e in array)
{
    if(e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);