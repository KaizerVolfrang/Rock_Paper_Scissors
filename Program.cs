using System;

namespace ConsoleApp1
{
    class Program
    {
        static int value { get; set; }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Камень, ножницы, бумага!");
            program.Print();
        }

        private string Print()
        {
            Console.WriteLine("Нажми 1 чтобы начать игру,\n 2 чтобы выйти нахуй блять");
            var result = Console.ReadLine();
            if (result == "1")
            {
                Instruction();
            }
            else if(result == "2")
            {
                return result;
            }
            return result;
        }

        private void GenerateNum()
        {
            int[] nums = new int[3] { 1, 2, 3 };
            Random rnd = new Random();
            for (int i = 0; i < 1; i++)
            {
                i = rnd.Next(1, 4);
                value = i;
                Console.WriteLine($"Выбор компа: {value}");
            }
        }

        private void Instruction()
        {
            for (;;)
            {
                Console.WriteLine("Выбери номер действия из 3 предложенных:\n Камень - 1 Ножницы - 2 Бумага - 3");

                var selection = int.Parse(Console.ReadLine());
                if(selection < 1 || selection > 3)
                {
                    Console.WriteLine("Dalbayeb vvedi deistvie normalnoe .|."); 
                    var slovo = Console.ReadLine();
                    Console.WriteLine("A teper izvinis vvedya slovlo извини");
                    while (slovo != "извини")
                        slovo = Console.ReadLine();
                }
                GenerateNum();

                if (selection < value && selection - value == 1 || selection - value == -1)
                    Console.WriteLine("Победил игрок");

                else if (selection > value && selection - value == 1 || selection - value == -1)
                    Console.WriteLine("Победил комп");

                else
                    Console.WriteLine("Ничья");
                Console.WriteLine("Играем дальше? ;)");
            }
        }
    }
}
