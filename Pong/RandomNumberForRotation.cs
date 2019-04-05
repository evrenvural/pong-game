using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    static class RandomNumberForRotation
    {
        public static int Rndm()
        {
            Random rndm = new Random();
            int number;

            do
            {
                number = rndm.Next(0, 8);

            } while (number == 0 || number == 4);

            return number;
        }
    }
}
