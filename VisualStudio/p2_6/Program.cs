using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("0～6の数字を入力してください。対応した曜日を表示します。");
                    string s = Console.ReadLine();
                    int weekNo = int.Parse(s);
                    //Console.WriteLine(stock);
                    string msg = "0～6の範囲で入力してください";
                    switch (weekNo)
                    {
                        case 0:
                            msg = "日曜日";
                            break;
                        case 1:
                            msg = "月曜日";
                            break;
                        case 2:
                            msg = "火曜日";
                            break;
                        case 3:
                            msg = "水曜日";
                            break;
                        case 4:
                            msg = "木曜日";
                            break;
                        case 5:
                            msg = "金曜日";
                            break;
                        case 6:
                            msg = "土曜日";
                            break;
                    }
                    Console.WriteLine(msg);
                }
                catch
                {
                    Console.WriteLine("数字を入力してください");
                    // Console.WriteLine(ex.ToString());
                }
            }

        }
    }
}
