using System;

namespace p14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while(true){
				Console.Write("A:");
				string s = Console.ReadLine();
				if(s == ""){
					continue;
				}
				double a = double.Parse(s);
				
				Console.Write("B:");
				s = Console.ReadLine();
				if(s == ""){
					continue;
				}
				double b = double.Parse(s);
				
				Console.Write("A:" + a + " B:" + b);
				
				string msg = a + "と" + b + "は等しい";

				if(a > b){
					msg = a + "は" + b + "より大きい";
				}else if(a < b){
					msg = a + "は" + b + "より小さい";
				}
				
				Console.WriteLine(" ... " + msg);
			}

		}
	}
}
