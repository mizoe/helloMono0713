using System;

namespace p11
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] testAges = new int[20];
			for (int i = 0; i < testAges.Length; i++) {
				testAges[i] = i;
			}
			foreach (var item in testAges) {
				var msg = item.ToString();
				if(item >= 7 && item <= 12){
					msg += " 小学生";
				}else if(item >= 13 && item <= 15){
					msg += " 中学生";
				}
				Console.WriteLine(msg);
			}
		}
	}
}









