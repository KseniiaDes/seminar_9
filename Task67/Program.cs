// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{
    num = Math.Abs(num);
    if (num == 0) return 0;
    return num % 10 + SumOfDigits(num / 10);
}

int result = SumOfDigits(number);
Console.WriteLine(result);


// int Factorial(int n)
// {
// if(n == 1) return 1;
// else return n * Factorial(n-1);
// }