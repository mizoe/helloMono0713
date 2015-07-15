using System;

namespace p17
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			while(true){
				try {
					Console.Write("点数:");
					string s = Console.ReadLine();
					int score = int.Parse(s);
					//Console.WriteLine(stock);
					string msg = "D判定";
					if(score >= 80){
						msg = "A判定";
					}else if(score >= 70){
						msg = "B判定";
					}else if(score >= 60){
						msg = "C判定";
					}
					Console.WriteLine(msg);
				} catch {
					Console.WriteLine("正の整数を入力してください");
					// Console.WriteLine(ex.ToString());
				}
			}
		}
	}
}
