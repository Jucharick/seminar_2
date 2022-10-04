int n = new Random().Next (100, 1000); // 1000 не включается
Console.WriteLine(n);
int first = n/100;
int third = n%10;
Console.WriteLine(first);
Console.WriteLine(third);
Console.WriteLine(first*10+third);