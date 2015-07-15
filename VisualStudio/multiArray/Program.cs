using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] foods = new string[3, 2];
            foods[0, 0] = "りんご";
            foods[0, 1] = "みかん";
            foods[1, 0] = "コーヒー";
            foods[1, 1] = "紅茶";
            foods[2, 0] = "ビール";
            foods[2, 1] = "日本酒";

            int i = 0;
            foreach (var item in foods)
            {
                Console.WriteLine("{0} : {1}",i,item);
                i++;
            }
        }
    }
}
