//Задача 4: Напишите программу, которая на вход принимает натуральное число N,
//а на выходе показывает его цифры через запятую.



class Program
{
    static void Main()
    {
        DisplayNSepByCommas();
    }

    static void DisplayNSepByCommas()
    {
        Console.Write("Введите натуральное число N: ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите натуральное число.");
            return;
        }

        string numberString = n.ToString();

        Console.Write("Цифры числа через запятую: ");
        
        for (int i = 0; i < numberString.Length; i++)
        {
            Console.Write(numberString[i]);

            if (i < numberString.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }
}




       
