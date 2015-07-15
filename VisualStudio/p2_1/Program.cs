using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable stocks = new Hashtable();
            stocks["やくそう"] = 50;
            stocks["どくけしそう"] = 20;
            stocks["せかいじゅのは"] = 1;
            stocks["せいすい"] = 3;

            foreach (var item in stocks.Keys)
            {
                Console.WriteLine(
                    "{0}\t{1,2}個",
                    item,
                    stocks[item].ToString()
                );
            }
        }
    }
}
