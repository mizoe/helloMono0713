using System;

namespace p12
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while(true){
				string s = Console.ReadLine();
				if(s == ""){
					continue;
				}
				int inputInt = int.Parse(s);
				string msg = "献血できません";
				if(inputInt >= 16 && inputInt <= 69){
					msg = "献血できます";
				}
				Console.WriteLine(msg);
			}
		}
	}
}
