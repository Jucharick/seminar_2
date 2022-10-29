int n = new Random().Next(10, 99);
Console.WriteLine($"случайное число: {n}");
// int first = n/10;
// int second = n%10;
// Console.WriteLine(first);
// Console.WriteLine(second);
// if (first > second)
// {
//     Console.WriteLine("max = "+ first);
// }
// else
// {
//     Console.WriteLine("max = "+ second);
// }
// // 

int MaxDigit(int num)
{
    int firstDigit = n / 10;
    int secondDigit = n % 10;

    if (firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit; // firstDigit больше secondDigit ? да - возвращает firstDigit, нет - возвращает secondDigit
}


int maxDigit = MaxDigit(n);
string result = maxDigit != -1 ? maxDigit.ToString() : "Цифры одинаковые"; // .ToString() чтоб не было ошибки, для вывода результата в данном случае это не важно

Console.WriteLine($"Наибольшая цифра числа {n} => {result}");