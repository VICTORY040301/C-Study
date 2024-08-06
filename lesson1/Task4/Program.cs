// Задача с 5-ю гирями

int a = 5;
int b = 6;
int c = 2;
int d = 1;
int e = 5;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
Console.WriteLine(max);