// Вывести факториал числа n, где гарантируется, что n не больше 10.

Console.WriteLine("Введите целое число от 1 до 10: ");
int n = int.Parse(Console.ReadLine());

if (n > 0 && n <= 10)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++) factorial *= i;
    Console.WriteLine($"Факториал числа: {n} = {factorial}");
} else
{
    Console.WriteLine("Введенное число некорректно");
}
