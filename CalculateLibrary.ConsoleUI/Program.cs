using CalculateLibrary.Calculators;
using System;

namespace CalculateLibrary.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Выражение: ");
                    Console.WriteLine($"Результат: {StringCalculator.Calculate(Console.ReadLine())}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка! {ex.Message}.\n");
                }
            }
        }
    }
}
