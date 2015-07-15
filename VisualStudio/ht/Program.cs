using System;
using System.Collections;

namespace ht
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["Apple"] = "りんご";
            ht["Orange"] = "オレンジ";
            ht["Strawberry"] = 15;
            ht[0] = "くだもの";

            Console.WriteLine(ht["Apple"]);
            Console.WriteLine(ht["Orange"]);
            Console.WriteLine(ht["Strawberry"]);
            Console.WriteLine(ht[0]);

            foreach (var key in ht.Keys)
            {
                Console.WriteLine("{0} : {1}", key, ht[key]);
            }

        }
    }
}
