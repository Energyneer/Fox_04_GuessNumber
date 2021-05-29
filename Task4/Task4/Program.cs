using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            WriteMessage(2);
            int i = -1;
            while (true)
            {
                Console.Write("Enter a number between 0 and 100: ");
                int inputValue = -1;
                if (!InputEncoder.CheckAndParse(Console.ReadLine(), out inputValue))
                    continue;
                int result = game.CheckNumber(inputValue);
                WriteMessage(result);
                if (result == 0)
                {
                    if (More())
                    {
                        game.GenerateNewNumber();
                        WriteMessage(2);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void WriteMessage(int code)
        {
            switch (code)
            {
                case -1: Console.WriteLine("Try more!"); break;
                case 0: Console.WriteLine("You are winner!"); break;
                case 1: Console.WriteLine("Try less!"); break;
                case 2: Console.WriteLine("Start new game!"); break;
                default: Console.WriteLine("> Error"); break;
            }
        }

        private static bool More()
        {
            bool again = false;
            while (true)
            {
                Console.Write("Play again? ");
                if (InputEncoder.CheckAgain(Console.ReadLine(), out again))
                    break;
            }
            return again;
        }
    }
}
