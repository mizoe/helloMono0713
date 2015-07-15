using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] stocks = new int[3, 4];
            stocks[0, 0] = 1;
            stocks[0, 1] = 99;
            stocks[0, 2] = 100;
            stocks[0, 3] = 50;
            stocks[1, 0] = 2;
            stocks[1, 1] = 200;
            stocks[1, 2] = 5000;
            stocks[1, 3] = 3000;
            stocks[2, 0] = 3;
            stocks[2, 1] = 50;
            stocks[2, 2] = 90;
            stocks[2, 3] = 33;

            Console.WriteLine("商品番号　在庫　販売価格　仕入価格");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0,8}{1,6}{2,10}{3,10}",
                    stocks[i, 0],
                    stocks[i, 1],
                    stocks[i, 2],
                    stocks[i, 3]
                    );
            }
        }
    }
}
