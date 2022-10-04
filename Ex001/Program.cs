// int[] array = { 10, 11, 12, 14, 99 };
// Console.WriteLine(array);

int n = new Random().Next (10, 99);
Console.WriteLine(n);
int first = n/10;
int second = n%10;
Console.WriteLine(first);
Console.WriteLine(second);
if (first > second)
{
    Console.WriteLine("max = "+ first);
}
else
{
    Console.WriteLine("max = "+ second);
}