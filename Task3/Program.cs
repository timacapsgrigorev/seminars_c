//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (IsEven(number))
            {
                Console.WriteLine($"Число {number} является чётным.");
            }
            else
            {
                Console.WriteLine($"Число {number} является нечётным.");
            }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

