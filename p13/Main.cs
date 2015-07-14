using System;

namespace p13
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while(true){
				Console.Write("年齢を入力して下さい:");
				string s = Console.ReadLine();
				if(s == ""){
					continue;
				}
				int age = int.Parse(s);

				Console.Write("身長を入力して下さい:");
				s = Console.ReadLine();
				if(s == ""){
					continue;
				}
				int height = int.Parse(s);

				Console.Write("年齢:" + age + "身長:" + height);

				string msg = "乗れません";
				if(age >= 6 && height >= 120){
					msg = "乗れます";
				}

				Console.WriteLine(" ... " + msg);
			}
		}
	}
}











