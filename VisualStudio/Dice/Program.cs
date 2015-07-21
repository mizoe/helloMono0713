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

            Dice[] dice = new Dice[3];
            var player = new Player();

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Dice();
            }

            while (true)
            {
                string input = Console.ReadLine();
                string msg = "";
                if (input == "h")
                {
                    for (int i = 0; i < dice.Length; i++)
                    {
                        msg += dice[i].getHistory();
                        msg += dice[i].getStats();
                    }
                }
                else
                {
                    var allResults = new int[dice.Length];
                    for (int i = 0; i < dice.Length; i++)
                    {
                        int result = dice[i].Roll();
                        msg += " " + result.ToString();
                        allResults[i] = result;
                    }
                    int score = player.calcPoint(allResults);
                    msg += " 結果:" + score + "ポイント"
                         + " 残高:" + player.point +"ポイント";
                }
                Console.Write(msg);
            }
        }
    }
}
