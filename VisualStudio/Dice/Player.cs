using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Player
    {
        public int point;
        public Player()
        {
            point = 1000;
        }
        public int calcPoint(int[] iArr)
        {
            var r = new List<int>();
            foreach (var item in iArr)
            {
                r.Add(item);
            }
            r.Sort(); // 小さい順
            int score = -50;
            if (r[0] == r[1] && r[1] == r[2]) //ゾロ目
            {
                score = 150;
            } else if (r[0] == 4 && r[1] == 5 && r[2] == 6) // 456
            {
                score = 250;
            } else if (r[0] == 1 && r[1] == 2 && r[2] == 3) // 123
            {
                score = -100;
            }
            point += score;
            return score;
        }
    }
}
