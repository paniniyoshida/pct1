using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;

        while (choice != 0)
        {
            DisplayMenu();
            choice = GetChoice();

            switch (choice)
            {
                case 1:
                    GuessNumberGame();
                    break;
                case 2:
                    MultiplicationTable();
                    break;
                case 3:
                    Divisors();
                    break;
                case 0:
                    Console.WriteLine("Выход из программы");
                    break;
                default:
                    Console.WriteLine("Неправильный выбор");
                    break;
            }

            Console.WriteLine("------------------------------------");
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Игра \"Угадай число\"");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("0. Выход");
    }

    static int GetChoice()
    {
        Console.Write("Введите номер программы: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void GuessNumberGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int guess = -1;
        int attempts = 0;

        Console.WriteLine("Загадано число от 0 до 100. Угадайте его!");

        while (guess != randomNumber)
        {
            Console.Write("Ваше предположение: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Загаданное число больше");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше");
            }
            else
            {
                Console.WriteLine("Вы угадали число!");
                Console.WriteLine("Потребовалось попыток: " + attempts);
            }
        }
    }

    static void MultiplicationTable()
    {
        int[,] table = new int[10, 10];

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                table[row, col] = (row + 1) * (col + 1);
            }
        }

        Console.WriteLine("Таблица умножения:");

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write(table[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Divisors()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Делители числа " + number + ": ");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}
