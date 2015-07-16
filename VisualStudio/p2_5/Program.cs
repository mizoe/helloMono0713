using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores["矢吹"] = 2;
            scores["丹下"] = 74;
            scores["力石"] = 80;
            scores["白木"] = 100;
            scores["西"] = 10;
            int total = 0;

            foreach (var key in scores.Keys)
            {
                var name = key;
                //氏名：矢吹　点数：  2
                if (key.Length == 1)
                {
                    name = "　" + key;
                }
                var rank = "不可";
                int jadge = scores[key] / 10;
                switch (jadge)
                {
                    case 10:
                    case 9:
                    case 8:
                        rank = "優";
                        break;
                    case 7:
                        rank = "良";
                        break;
                    case 6:
                        rank = "可";
                        break;
                }
                Console.WriteLine("氏名：{0} 点数：{1,3} 評価：{2}", name, scores[key], rank);
                total += scores[key];

            }

            Console.WriteLine("受験者\t{0,3}名", scores.Count);
            Console.WriteLine("合計点\t{0,3}点", total);
            Console.WriteLine("平均点\t{0,3}点", total / scores.Count);
        }
    }
}
