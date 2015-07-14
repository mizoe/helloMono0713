using System;

namespace p10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] ages = new int[]{18,11,30,15,55,32,10};
			foreach (var item in ages) {
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
