﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}.");
    Console.WriteLine($"Число {number2} меньше числа {number1}.");
}
else if (number1 < number2)
{
    Console.WriteLine($"Число {number2} больше числа {number1}.");
    Console.WriteLine($"Число {number1} меньше числа {number2}.");
}
else
{
    Console.WriteLine("Числа равны.");
}
 
