using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class InputEncoder
    {
        public static bool CheckAndParse(string line, out int value)
        {
            try
            {
                value = int.Parse(line);
                if (value < 0 || value > 100)
                    return false;
            }
            catch
            {
                value = -1;
                return false;
            }
            return true;
        }

        public static bool CheckAgain(string line, out bool again)
        {
            string lineUpCase = line.ToUpper();
            again = false;
            if (lineUpCase == "YES" || lineUpCase == "Y")
            {
                again = true;
                return true;
            } else if (lineUpCase == "NO" || lineUpCase == "N")
            {
                return true;
            }
            return false;
        }
    }
}
