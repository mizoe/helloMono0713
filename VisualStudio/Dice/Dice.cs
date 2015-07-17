using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        public int Roll()
        {
            Random r = new Random();
            return r.Next(1, 7);
        }
    }
}
