using System;

namespace p16
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while(true){
				try {
					Console.Write("在庫:");
					string s = Console.ReadLine();
					if(s == ""){
						continue;
					}
					int stock = int.Parse(s);
					//Console.WriteLine(stock);
					string msg = "在庫があります";
					if(stock < 0){
						msg = "正の整数を入力してください";
					}else if(stock == 0){
						msg = "在庫がありません";
					}else if(stock <= 3){
						msg = "在庫がわずかです";
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
