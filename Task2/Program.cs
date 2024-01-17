//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
//в которой находится эта точка.

using System;

void GetNumOfCoordQuad()
{
    // Ввод координат X и Y
    Console.Write("X: ");
    double x = double.Parse(Console.ReadLine());

    Console.Write("Y: ");
    double y = double.Parse(Console.ReadLine());

    // Определение номера координатной четверти
    int quadrant = DetermineQuad(x, y);

    // Вывод результата
    Console.WriteLine($"Точка находится в {quadrant}-й координатной четверти.");
}

int DetermineQuad(double x, double y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
    // Если точка не принадлежит ни одной координатной четверти, возвращаем 0
    return 0;
}

// Точка входа
GetNumOfCoordQuad();