// count (a*b/(c+d)); a, b, c, d - int or long

int a = 5;
int b = 3;
long c = 7;
long d = 8;
int prod = a * b;
long sum = c + d;
long result = prod / sum;
Console.WriteLine(result);