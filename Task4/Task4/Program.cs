using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            WriteMessage(Promt.NEW_GAME);
            while (true)
            {
                Console.Write("Enter a number between 0 and 100: ");
                int inputValue = -1;
                if (!InputEncoder.CheckAndParse(Console.ReadLine(), out inputValue))
                    continue;
                Promt result = game.CheckNumber(inputValue);
                WriteMessage(result);
                if (result == Promt.EQUAL)
                {
                    if (More())
                    {
                        game.GenerateNewNumber();
                        WriteMessage(Promt.NEW_GAME);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void WriteMessage(Promt code)
        {
            switch (code)
            {
                case Promt.LESS: Console.WriteLine("Try more!"); break;
                case Promt.EQUAL: Console.WriteLine("You are winner!"); break;
                case Promt.MORE: Console.WriteLine("Try less!"); break;
                case Promt.NEW_GAME: Console.WriteLine("Start new game!"); break;
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
