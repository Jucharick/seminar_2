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