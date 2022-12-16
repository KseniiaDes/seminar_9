// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите натуральные числа M и N для вывода ряда чисел от M до N");
Console.Write("Введите M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void NumbersFromMtoN(int num1, int num2)
{
    if (num1 < num2)
    {
        NumbersFromMtoN(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num1 > num2)
    {
        NumbersFromMtoN(num1, num2 + 1);
        Console.Write($"{num2} ");
    }
    else Console.Write($"{num2} ");
}

NumbersFromMtoN(number1, number2);