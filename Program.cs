using System;

namespace ConsoleApp1
{
    class Program
    {

        static int selection { get; set; }
        static int value { get; set; }
        static string slovo { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Камень, ножницы, бумага!");
            Instruction();
        }

         enum Operation
         {
             Stone = 1,
             Scissors = 2,
             Paper = 3
         }
        static void GenerateNum()
        {
            Operation op;
            Random rnd = new Random();
            value = rnd.Next(1, 4);
            op = (Operation)value;
            Console.WriteLine($"Выбор компа: {op}");
        }

        static void Instruction()
        {
            Operation[] op = new Operation[] {};
            for (; ;)
            {
                Console.WriteLine($"Выбери номер действия из 3 предложенных:\n Камень - 1 Ножницы - 2 Бумага - 3");

                selection = int.Parse(Console.ReadLine());
                while (1 > selection || selection > 3)
                {
                    Console.WriteLine("vvedi deistvie normalnoe .|.");
                    selection = int.Parse(Console.ReadLine());

                    do
                    {
                        Console.WriteLine("izvinis vvedya slovlo извини");
                        slovo = Console.ReadLine();
                    }
                    while (slovo != "извини");
                }

                
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали Камень");
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали ножницы");
                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали бумагу");
                        break;
                }

                GenerateNum();

                if (selection == 1 && value == 2 || selection == 2 && value == 3 || selection == 3 && value == 1)  
                    Console.WriteLine("Победил игрок");
                
                else if (value == 1 && selection == 2 || value == 2 && selection == 3 || value == 3 && selection == 1)
                    Console.WriteLine("Победил комп");

                else
                    Console.WriteLine("Ничья");

                Console.WriteLine("Играем дальше? ;)");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
