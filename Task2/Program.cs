//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number3 = int.Parse(Console.ReadLine());

int maxNumber = GetMaxNumber(number1, number2, number3);
Console.WriteLine($"Максимальное число: {maxNumber}");
        

static int GetMaxNumber(int a, int b, int c)
{
    int max = a;

    if (b > max)
    {
        max = b;
    }

    if (c > max)
    {
        max = c;
    }

    return max;
}
