// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 2




Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99 || number > 999)
    {
        Console.WriteLine("Ошибка! Введите трехзначное число.");
    }
else
        {
           
        int digit2 = (number / 10) % 10;

        Console.WriteLine($"{number}: {digit2}");
        }
    








