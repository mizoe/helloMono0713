using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        private int[] stats; //統計
        private List<int> history; //履歴
        private int total; //総計
        private Random r; //乱数
        private static int num = 0;

        public Dice()
        {
            stats = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            history = new List<int>();
            r  = new Random(num);
            total = 0;
            num++;
        }

        public int Roll()
        {
            //サイコロをふる
            int result = r.Next(1, 7);
            //総計を追加
            total++;
            //履歴に保存
            history.Add(result);
            //統計配列に保存
            stats[result]++;
            //結果を返す
            return result;
        }

        //統計情報を出す
        public string getStats()
        {
            string msg = "";
            int sum = 0;
            for (int i = 1; i <= 6; i++)
            {
                double ratio = stats[i] * 100 / total;
                msg += i + ":" + stats[i] + "(" + ratio + "%)\n";
                sum += stats[i] * i;
            }
            msg += "合計: " + total + "回\n";
            msg += "平均: " + ((double)sum / total) + "\n";
            return msg;
        }
        //履歴情報を出す
        public string getHistory()
        {
            string msg = "履歴：";
            foreach (var item in history)
            {
                msg += " " + item;
            }
            return msg;
        }
    }
}
