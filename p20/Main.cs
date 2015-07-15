using System;

namespace p20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 0; i <= 10; i++) {
				string msg = i + ":かねだ";
				for (int j = 0; j < i; j++) {
					msg += "あ";
				}
				Console.WriteLine(msg);
			}
		}
	}
}
