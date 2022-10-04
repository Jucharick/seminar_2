Console.WriteLine("Введите целое число:");
int first = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите второе целое число:");
int second = Convert.ToInt32(Console.ReadLine());

if (first * first == second | second * second == first)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}