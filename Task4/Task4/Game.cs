using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Game
    {
        private int ReqNumber { get; set; }

        public Game()
        {
            GenerateNewNumber();
        }

        public Game(int reqNumber)
        {
            ReqNumber = reqNumber;
        }

        public void GenerateNewNumber()
        {
            Random random = new Random();
            ReqNumber = random.Next(0, 101);
        }

        public Promt CheckNumber(int proposed)
        {
            return proposed == ReqNumber ? Promt.EQUAL : proposed < ReqNumber ? Promt.LESS : Promt.MORE;
        }
    }

    public enum Promt
    {
        LESS,
        EQUAL,
        MORE,
        NEW_GAME
    }
}
