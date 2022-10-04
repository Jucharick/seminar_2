Console.WriteLine("Введите первое целое число:");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int second = Convert.ToInt32(Console.ReadLine());
if (first % second == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}