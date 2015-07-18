using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice[] dice = new Dice[4];
            dice[0] = new Dice();
            dice[1] = new Dice();
            dice[2] = new Dice();
            dice[3] = new Dice();

            while (true)
            {
                string input = Console.ReadLine();
                string msg = "";
                if (input == "h")
                {
                    msg = dice[0].getHistory();
                    msg += dice[0].getStats();
                    msg += dice[1].getHistory();
                    msg += dice[1].getStats();
                    msg += dice[2].getHistory();
                    msg += dice[2].getStats();
                    msg += dice[3].getHistory();
                    msg += dice[3].getStats();
                }
                else
                {
                    int result = dice[0].Roll();
                    msg = result.ToString();
                    result = dice[1].Roll();
                    msg += " " + result.ToString();
                    result = dice[2].Roll();
                    msg += " " + result.ToString();
                    result = dice[3].Roll();
                    msg += " " + result.ToString();
                }
                Console.Write(msg);
            }
        }
    }
}
