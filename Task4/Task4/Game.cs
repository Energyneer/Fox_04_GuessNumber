using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Game
    {
        public int ReqNumber { get; set; }

        public Game()
        {
            GenerateNewNumber();
        }

        public void GenerateNewNumber()
        {
            Random random = new Random();
            ReqNumber = random.Next(0, 101);
        }

        public int CheckNumber(int proposed)
        {
            return proposed == ReqNumber ? 0 : proposed < ReqNumber ? -1 : 1;
        }
    }
}
