//Задача 3: Напишите программу, которая
//принимает на вход целое число из отрезка [10, 99]
//и показывает наибольшую цифру числа.

void GetMaxDigit()
{
    Console.Write("Введите целое число от 10 до 99: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 10 && number <= 99)
    {
        int maxDigit = Math.Max(number / 10, number % 10);
        Console.WriteLine($"Наибольшая цифра числа {number}: {maxDigit}");
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Введите целое число от 10 до 99.");
    }
}
GetMaxDigit();