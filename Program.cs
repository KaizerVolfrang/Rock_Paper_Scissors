using System;

namespace ConsoleApp1
{
    enum Operation
    {
        Paper = 1,
        Scissors = 2,
        Stone = 3,
    }

    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Random rnd = new Random();
                bool validation;
                int rawSelection;
                Operation selection;
                Operation botSelection;
                string slovo;

                Console.WriteLine($"Выбери номер действия из 3 предложенных:\n Бумага - 1 Ножницы - 2 Камень - 3");

                validation = int.TryParse(Console.ReadLine(), out rawSelection);

                while ((validation && rawSelection > 0 && rawSelection < 4) == false)
                {
                    Console.WriteLine("vvedi deistvie normalnoe .|.");
                    validation = int.TryParse(Console.ReadLine(), out rawSelection);

                    do
                    {
                        Console.WriteLine("izvinis vvedya slovlo извини");
                        slovo = Console.ReadLine();
                    }
                    while (slovo != "извини");
                }

                selection = (Operation)rawSelection;
                botSelection = (Operation)rnd.Next(1, 4);

                Console.WriteLine($"Ваш выбор: {GetRuSelectionValue(selection)}");

                Console.WriteLine($"Выбор компа: {GetRuSelectionValue(botSelection)}");

                Console.WriteLine(CalculateResult(selection, botSelection));

                Console.WriteLine("Играем дальше? ;)");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static string GetRuSelectionValue(Operation selection)
        {
            switch (selection)
            {
                case Operation.Stone:
                    return "камень";
                case Operation.Scissors:
                    return "ножницы";
                case Operation.Paper:
                    return "бумага";
                default:
                    return "";
            }
        }

        static string CalculateResult(Operation selection, Operation botSelection)
        {
            if(selection == botSelection)
            {
                return "Ничья";
            } 
            else if(selection == Operation.Paper && botSelection == Operation.Stone)
            {
                return "Выйграл игрок";
            }
            else if (selection == Operation.Stone && botSelection == Operation.Paper)
            {
                return "Выйграл комп";
            }
            else if (selection > botSelection)
            {
                return "Выйграл игрок";
            } 
            else
            {
                return "Выйграл комп";
            }
        }
    }
}
