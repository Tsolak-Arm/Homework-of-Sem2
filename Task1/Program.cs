//Задача 1: Напишите программу,
//которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.

void MultipleOfNumber(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"да, {num} кратно");
    }
    else
    {
        Console.WriteLine($"нет, {num} не кратно");
    }
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

MultipleOfNumber(num);


