using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Виведення привітання
            Console.WriteLine("Привіт! Це проста програма на C#.");
            Console.WriteLine("Давай додамо два числа!");

            // Введення першого числа
            Console.Write("Введи перше число: ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            // Введення другого числа
            Console.Write("Введи друге число: ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            // Додавання чисел
            int sum = number1 + number2;

            // Виведення результату
            Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює {sum}");

            // Завершення програми
            Console.WriteLine("Дякую за використання програми! Натисни будь-яку клавішу для виходу.");
            Console.ReadKey();
        }
    }
}
