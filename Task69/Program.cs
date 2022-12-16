// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите натуральные числа A и B для возведения числа A в степень B");
Console.Write("Введите A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Power(int a, int b)
{
    if (b == 0) return 1;
    return a * Power(a, b - 1);
}

int result = Power(numberA, numberB);
Console.WriteLine(result);