using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] foods = new string[3][];
            foods[0] = new string[] { "りんご", "みかん" };
            foods[1] = new string[] { "コーヒー", "紅茶", "緑茶" };
            foods[2] = new string[] { "ビール" };

            var i = 0;
            foreach (var arr in foods)
            {
                var j = 0;
                foreach (var item in arr)
                {
                    Console.WriteLine("{0}-{1} : {2}", i, j, item);
                    j++;
                }
                i++;
            }
        }
    }
}
