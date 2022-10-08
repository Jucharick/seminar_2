Console.WriteLine("Введите целое число:");
int first = Convert.ToInt32(Console.ReadLine());

// if (first == 0 )
// {
//     Console.WriteLine("Ноль делить нельзя");
// }
// else
// {
//     if (first % 7 == 0 && first % 23 == 0)
//     {
//         Console.WriteLine("Кратно");
//     }
//     else
//     {
//         Console.WriteLine("Не кратно");
//     }
// }

bool isMultiplicity (int a)
{
    return (a%7==0 && a%23==0);
}

if (isMultiplicity (first))
{
    Console.WriteLine("Делится!");
}
else 
{
    Console.WriteLine("Не делится!");
}