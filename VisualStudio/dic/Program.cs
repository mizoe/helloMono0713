using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["りんご"] = 100;
            dic["みかん"] = 10;
            dic["やくそう"] = 3;

            Console.WriteLine(dic["りんご"]);
            Console.WriteLine(dic["みかん"]);
            Console.WriteLine(dic["やくそう"]);

            foreach (var key in dic.Keys)
            {
                Console.WriteLine("{0} : {1}", key, dic[key]);
            }
        }
    }
}
