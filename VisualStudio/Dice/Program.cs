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
            var dice    = new Dice();
            var history = new List<int>();
            var stats   = new int[7] {0,0,0,0,0,0,0};
            var total = 0;

            while (true)
            {
                string input = Console.ReadLine();
                string msg = "";
                if (input == "h")
                {
                    msg = "履歴：";
                    foreach (var item in history)
                    {
                        msg += " " + item;
                    }
                    msg += "\n";
                    int sum = 0;
                    for (int i = 1; i <= 6; i++)
                    {
                        double ratio = stats[i] * 100 / total;
                        msg += i + ":" + stats[i] + "(" + ratio + "%)\n";
                        sum += stats[i] * i;
                    }
                    msg += "合計: " + total + "回\n";
                    msg += "平均: " + ((double)sum/total) + "\n";
                }
                else
                {
                    int result = dice.Roll();
                    history.Add(result);
                    stats[result]++;
                    total++;
                    msg = result.ToString();
                }
                Console.Write(msg);
            }
        }
    }
}
